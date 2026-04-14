using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class SiparisDetayForm : Form
    {
        private AppDbContext _context;
        private Satis _satis;
        private bool _modified = false;

        public static event EventHandler? OrderUpdated;

        public SiparisDetayForm(int satisId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _satis = _context.Satislar
                .Include(s => s.Musteri)
                .Include(s => s.Detaylar)
                .ThenInclude(d => d.Urun)
                .FirstOrDefault(s => s.Id == satisId);
            if (_satis == null)
            {
                MessageBox.Show("Sipariş bulunamadı.");
                Close();
                return;
            }
            LoadData();
        }

        private void LoadData()
        {
            Text = $"Sipariş #{_satis.Id} - {_satis.Musteri.Ad} {_satis.Musteri.Soyad}";
            lblMusteri.Text = $"{_satis.Musteri.Ad} {_satis.Musteri.Soyad}\n{_satis.Musteri.Telefon}\n{_satis.Musteri.Adres}";
            dtpTarih.Value = _satis.SatisTarihi;
            txtKargoNo.Text = _satis.KargoTakipNo;
            txtNotlar.Text = _satis.Notlar;
            txtIndirim.Text = (_satis.Indirim ?? 0).ToString();
            txtKargoUcreti.Text = (_satis.KargoUcreti ?? 0).ToString();

            if (dgvSepet.Columns.Count == 0)
            {
                dgvSepet.Columns.Add("UrunAdi", "Ürün Adı");
                dgvSepet.Columns.Add("Miktar", "Miktar");
                dgvSepet.Columns.Add("BirimFiyat", "Birim Fiyat");
                dgvSepet.Columns.Add("Toplam", "Toplam");
                dgvSepet.Columns.Add("Maliyet", "Maliyet");
                dgvSepet.Columns.Add("Kar", "Kar");
                dgvSepet.Columns["UrunAdi"].Width = 200;
                dgvSepet.Columns["Miktar"].Width = 80;
                dgvSepet.Columns["BirimFiyat"].Width = 100;
                dgvSepet.Columns["Toplam"].Width = 100;
                dgvSepet.Columns["Maliyet"].Width = 100;
                dgvSepet.Columns["Kar"].Width = 100;
            }

            dgvSepet.Rows.Clear();
            decimal toplamBrut = 0;
            decimal toplamMaliyet = 0;

            if (_satis.Detaylar != null)
            {
                foreach (var detay in _satis.Detaylar)
                {
                    dgvSepet.Rows.Add(
                        detay.Urun?.UrunAdi ?? "?",
                        detay.Miktar,
                        detay.BirimFiyat.ToString("C2"),
                        detay.ToplamFiyat.ToString("C2"),
                        (detay.Urun?.AlisFiyati ?? 0).ToString("C2"),
                        (detay.ToplamFiyat - (detay.Miktar * (detay.Urun?.AlisFiyati ?? 0))).ToString("C2")
                    );
                    toplamBrut += detay.ToplamFiyat;
                    toplamMaliyet += detay.Miktar * (detay.Urun?.AlisFiyati ?? 0);
                }
            }

            decimal indirim = _satis.Indirim ?? 0;
            decimal kargo = _satis.KargoUcreti ?? 0;
            decimal netGelir = toplamBrut - indirim - kargo;
            decimal kar = netGelir - toplamMaliyet;

            lblToplamBrut.Text = toplamBrut.ToString("C2");
            lblIndirim.Text = indirim.ToString("C2");
            lblKargo.Text = kargo.ToString("C2");
            lblNetGelir.Text = netGelir.ToString("C2");
            lblMaliyet.Text = toplamMaliyet.ToString("C2");
            lblKar.Text = kar.ToString("C2");
            if (kar < 0) lblKar.ForeColor = System.Drawing.Color.Red;
            else lblKar.ForeColor = System.Drawing.Color.Green;
        }

        private void UpdateTotalAndSave()
        {
            decimal toplamBrut = _satis.Detaylar?.Sum(d => d.ToplamFiyat) ?? 0;
            _satis.ToplamTutar = toplamBrut - (_satis.Indirim ?? 0) - (_satis.KargoUcreti ?? 0);
            if (_satis.ToplamTutar < 0) _satis.ToplamTutar = 0;
            _context.SaveChanges();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _satis.SatisTarihi = dtpTarih.Value;
            _satis.KargoTakipNo = string.IsNullOrWhiteSpace(txtKargoNo.Text) ? null : txtKargoNo.Text.Trim();
            _satis.Notlar = string.IsNullOrWhiteSpace(txtNotlar.Text) ? null : txtNotlar.Text.Trim();
            _satis.Indirim = decimal.TryParse(txtIndirim.Text, out decimal indirim) ? indirim : 0;
            _satis.KargoUcreti = decimal.TryParse(txtKargoUcreti.Text, out decimal kargo) ? kargo : 0;

            UpdateTotalAndSave();
            OrderUpdated?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Sipariş güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _modified = false;
            LoadData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvSepet.CurrentRow == null) return;
            int index = dgvSepet.CurrentRow.Index;
            if (_satis.Detaylar == null || index >= _satis.Detaylar.Count) return;

            var detay = _satis.Detaylar.ToList()[index];

            var urun = _context.Urunler.Find(detay.UrunId);
            if (urun != null)
            {
                urun.StokMiktari += detay.Miktar;
                _context.Entry(urun).State = EntityState.Modified;  // Zorla güncelle
                var hareket = new StokHareket
                {
                    UrunId = urun.Id,
                    HareketTipi = "Giriş",
                    Miktar = detay.Miktar,
                    OncekiStok = urun.StokMiktari - detay.Miktar,
                    SonrakiStok = urun.StokMiktari,
                    Aciklama = $"Sipariş düzenleme #{_satis.Id} - ürün silindi",
                    Tarih = DateTime.Now
                };
                _context.StokHareketleri.Add(hareket);
            }

            _context.SatisDetaylari.Remove(detay);
            _modified = true;
            _context.SaveChanges();

            UpdateTotalAndSave();
            OrderUpdated?.Invoke(this, EventArgs.Empty);
            LoadData();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            using (var dialog = new UrunSecimDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK && dialog.SecilenUrun != null)
                {
                    string miktarStr = Microsoft.VisualBasic.Interaction.InputBox("Miktar girin:", "Ürün Ekle", "1");
                    if (int.TryParse(miktarStr, out int miktar) && miktar > 0)
                    {
                        AddProduct(dialog.SecilenUrun, miktar);
                    }
                }
            }
        }

        private void AddProduct(Urun urun, int miktar)
        {
            if (urun.StokMiktari < miktar)
            {
                MessageBox.Show("Yeterli stok yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detay = new SatisDetay
            {
                SatisId = _satis.Id,
                UrunId = urun.Id,
                Miktar = miktar,
                BirimFiyat = urun.SatisFiyati,
                ToplamFiyat = miktar * urun.SatisFiyati
            };
            _context.SatisDetaylari.Add(detay);

            urun.StokMiktari -= miktar;
            _context.Entry(urun).State = EntityState.Modified;  // Zorla güncelle
            var hareket = new StokHareket
            {
                UrunId = urun.Id,
                HareketTipi = "Çıkış",
                Miktar = miktar,
                OncekiStok = urun.StokMiktari + miktar,
                SonrakiStok = urun.StokMiktari,
                Aciklama = $"Sipariş düzenleme #{_satis.Id} - ürün eklendi",
                Tarih = DateTime.Now
            };
            _context.StokHareketleri.Add(hareket);

            _context.SaveChanges();

            UpdateTotalAndSave();
            OrderUpdated?.Invoke(this, EventArgs.Empty);
            LoadData();
            _modified = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (_modified && MessageBox.Show("Değişiklikleri kaydetmeden kapatmak istiyor musunuz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Close();
        }

        private void SiparisDetayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}