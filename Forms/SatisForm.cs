using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class SatisForm : Form
    {
        private AppDbContext _context;
        private List<SepetItem> _sepet;
        private Musteri? _seciliMusteri;

        public SatisForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _sepet = new List<SepetItem>();
            SepetGuncelle();
            MusteriBilgiGuncelle();
            txtIndirim.Text = "0";
            txtKargoUcreti.Text = "0";
        }

        private void MusteriBilgiGuncelle()
        {
            if (_seciliMusteri != null)
            {
                lblMusteriBilgi.Text = $"Ad Soyad: {_seciliMusteri.Ad} {_seciliMusteri.Soyad}\n" +
                                       $"Telefon: {_seciliMusteri.Telefon ?? "-"}\n" +
                                       $"Adres: {_seciliMusteri.Adres ?? "-"}";
            }
            else
            {
                lblMusteriBilgi.Text = "Müşteri seçilmedi.";
            }
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            using (var dialog = new MusteriDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Musteriler.Add(dialog.Musteri);
                    _context.SaveChanges();
                    _seciliMusteri = dialog.Musteri;
                    MusteriBilgiGuncelle();
                }
            }
        }

        private void btnMusteriListesi_Click(object sender, EventArgs e)
        {
            using (var dialog = new MusteriSecimDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK && dialog.SecilenMusteri != null)
                {
                    _seciliMusteri = dialog.SecilenMusteri;
                    MusteriBilgiGuncelle();
                }
            }
        }

        // Arama butonu
        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            string aranan = txtUrunAra.Text.Trim();
            if (string.IsNullOrEmpty(aranan)) return;

            var urunler = _context.Urunler
                .Where(u => u.UrunAdi.ToLower().Contains(aranan.ToLower()) ||
                            (u.Barkod != null && u.Barkod.ToLower().Contains(aranan.ToLower())))
                .Take(30)
                .ToList();

            // Liste için bir sınıf tanımla
            var listItems = urunler.Select(u => new UrunListItem
            {
                Id = u.Id,
                DisplayText = $"{u.UrunAdi} - {u.SatisFiyati:C2}",
                Urun = u
            }).ToList();

            listUrunSonuclari.DataSource = null;
            listUrunSonuclari.DisplayMember = "DisplayText";
            listUrunSonuclari.ValueMember = "Id";
            listUrunSonuclari.DataSource = listItems;
        }

        private void txtUrunAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUrunAra_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void listUrunSonuclari_DoubleClick(object sender, EventArgs e)
        {
            if (listUrunSonuclari.SelectedItem is UrunListItem selected)
            {
                string miktarStr = Microsoft.VisualBasic.Interaction.InputBox("Miktar girin:", "Ürün Ekle", "1");
                if (int.TryParse(miktarStr, out int miktar) && miktar > 0)
                {
                    SepeteEkle(selected.Urun, miktar);
                    txtUrunAra.Clear();
                    listUrunSonuclari.DataSource = null;
                }
            }
        }

        // Resimli galeri butonu
        private void btnResimliListe_Click(object sender, EventArgs e)
        {
            using (var galeri = new UrunGaleriForm())
            {
                if (galeri.ShowDialog() == DialogResult.OK && galeri.SecilenUrun != null)
                {
                    string miktarStr = Microsoft.VisualBasic.Interaction.InputBox("Miktar girin:", "Ürün Ekle", "1");
                    if (int.TryParse(miktarStr, out int miktar) && miktar > 0)
                    {
                        SepeteEkle(galeri.SecilenUrun, miktar);
                    }
                }
            }
        }

        private void btnBarkodEkle_Click(object sender, EventArgs e)
        {
            string barkod = txtBarkod.Text.Trim();
            if (!string.IsNullOrEmpty(barkod))
            {
                var urun = _context.Urunler.FirstOrDefault(u => u.Barkod == barkod);
                if (urun != null)
                {
                    string miktarStr = Microsoft.VisualBasic.Interaction.InputBox("Miktar girin:", "Ürün Ekle", "1");
                    if (int.TryParse(miktarStr, out int miktar) && miktar > 0)
                    {
                        SepeteEkle(urun, miktar);
                        txtBarkod.Clear();
                        txtBarkod.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Barkod bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SepeteEkle(Urun urun, int miktar)
        {
            var mevcut = _sepet.FirstOrDefault(s => s.UrunId == urun.Id);
            if (mevcut != null)
            {
                mevcut.Miktar += miktar;
                mevcut.Toplam = mevcut.Miktar * mevcut.BirimFiyat;
            }
            else
            {
                _sepet.Add(new SepetItem
                {
                    UrunId = urun.Id,
                    UrunAdi = urun.UrunAdi,
                    Miktar = miktar,
                    BirimFiyat = urun.SatisFiyati,
                    Toplam = miktar * urun.SatisFiyati
                });
            }
            SepetGuncelle();
        }

        private void SepetGuncelle()
        {
            dgvSepet.Rows.Clear();
            decimal genelToplam = 0;
            for (int i = 0; i < _sepet.Count; i++)
            {
                var item = _sepet[i];
                dgvSepet.Rows.Add(
                    item.UrunAdi,
                    item.Miktar,
                    item.BirimFiyat.ToString("C2"),
                    item.Toplam.ToString("C2"),
                    "Sil"
                );
                genelToplam += item.Toplam;
            }

            decimal indirim = 0;
            decimal kargo = 0;
            if (decimal.TryParse(txtIndirim.Text, out indirim) && indirim < 0) indirim = 0;
            if (decimal.TryParse(txtKargoUcreti.Text, out kargo) && kargo < 0) kargo = 0;

            decimal finalToplam = genelToplam - indirim - kargo;
            if (finalToplam < 0) finalToplam = 0;

            lblToplam.Text = finalToplam.ToString("C2");
        }

        private void txtIndirim_TextChanged(object sender, EventArgs e)
        {
            SepetGuncelle();
        }

        private void txtKargoUcreti_TextChanged(object sender, EventArgs e)
        {
            SepetGuncelle();
        }

        private void dgvSepet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                _sepet.RemoveAt(e.RowIndex);
                SepetGuncelle();
            }
        }

        private void dgvSepet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                var cell = dgvSepet.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int yeniMiktar))
                {
                    if (yeniMiktar > 0)
                    {
                        _sepet[e.RowIndex].Miktar = yeniMiktar;
                        _sepet[e.RowIndex].Toplam = yeniMiktar * _sepet[e.RowIndex].BirimFiyat;
                        SepetGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Miktar pozitif olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        SepetGuncelle();
                    }
                }
                else
                {
                    SepetGuncelle();
                }
            }
        }

        private void btnSatisKaydet_Click(object sender, EventArgs e)
        {
            if (_sepet.Count == 0)
            {
                MessageBox.Show("Sepet boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_seciliMusteri == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin veya yeni müşteri ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal indirim = 0;
            decimal kargo = 0;
            if (decimal.TryParse(txtIndirim.Text, out indirim) && indirim < 0) indirim = 0;
            if (decimal.TryParse(txtKargoUcreti.Text, out kargo) && kargo < 0) kargo = 0;

            decimal sepetToplam = _sepet.Sum(s => s.Toplam);
            decimal finalToplam = sepetToplam - indirim - kargo;
            if (finalToplam < 0) finalToplam = 0;

            var satis = new Satis
            {
                MusteriId = _seciliMusteri.Id,
                SatisTarihi = DateTime.Now,
                KargoTakipNo = string.IsNullOrWhiteSpace(txtKargoNo.Text) ? null : txtKargoNo.Text.Trim(),
                Notlar = string.IsNullOrWhiteSpace(txtNotlar.Text) ? null : txtNotlar.Text.Trim(),
                ToplamTutar = finalToplam,
                OdemeDurumu = "Ödendi",
                Indirim = indirim,
                KargoUcreti = kargo
            };
            _context.Satislar.Add(satis);
            _context.SaveChanges();

            foreach (var item in _sepet)
            {
                var urun = _context.Urunler.Find(item.UrunId);
                if (urun == null) continue;

                if (urun.StokMiktari < item.Miktar)
                {
                    MessageBox.Show($"Yeterli stok yok: {urun.UrunAdi}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _context.Satislar.Remove(satis);
                    _context.SaveChanges();
                    return;
                }

                urun.StokMiktari -= item.Miktar;

                var detay = new SatisDetay
                {
                    SatisId = satis.Id,
                    UrunId = item.UrunId,
                    Miktar = item.Miktar,
                    BirimFiyat = item.BirimFiyat,
                    ToplamFiyat = item.Toplam
                };
                _context.SatisDetaylari.Add(detay);

                var hareket = new StokHareket
                {
                    UrunId = item.UrunId,
                    HareketTipi = "Çıkış",
                    Miktar = item.Miktar,
                    OncekiStok = urun.StokMiktari + item.Miktar,
                    SonrakiStok = urun.StokMiktari,
                    Aciklama = $"Satış #{satis.Id}",
                    Tarih = DateTime.Now,
                    MusteriAdi = _seciliMusteri != null ? $"{_seciliMusteri.Ad} {_seciliMusteri.Soyad}" : null,
                    MusteriTelefon = _seciliMusteri?.Telefon
                };
                _context.StokHareketleri.Add(hareket);
            }
            _context.SaveChanges();

            MessageBox.Show("Satış başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _sepet.Clear();
            SepetGuncelle();
            txtKargoNo.Clear();
            txtNotlar.Clear();
            txtIndirim.Text = "0";
            txtKargoUcreti.Text = "0";
            _seciliMusteri = null;
            MusteriBilgiGuncelle();

            if (MessageBox.Show("Fiş yazdırılsın mı?", "Yazdır", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Yazıcı entegrasyonu yakında eklenecek.");
            }
        }

        private void SatisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }

    public class SepetItem
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; } = string.Empty;
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Toplam { get; set; }
    }

    public class UrunListItem
    {
        public int Id { get; set; }
        public string DisplayText { get; set; } = string.Empty;
        public Urun Urun { get; set; } = null!;
    }
}