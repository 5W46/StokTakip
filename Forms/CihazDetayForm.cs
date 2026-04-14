using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class CihazDetayForm : Form
    {
        private AppDbContext _context;
        private Cihaz _cihaz;
        private List<CihazYapilacak> _yapilacaklar = new List<CihazYapilacak>();
        private List<CihazHarcama> _harcamalar = new List<CihazHarcama>();

        public CihazDetayForm(Cihaz cihaz)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _cihaz = cihaz;
            Text = $"Cihaz Detayları - {cihaz.MarkaModel} ({cihaz.SeriNo})";

            // Cihaz bilgisi
            lblCihazBilgi.Text = $"Marka/Model: {cihaz.MarkaModel}\nSeri No: {cihaz.SeriNo}\nDurum: {cihaz.Durum}";

            // Alınan kişi bilgisi
            string alinan = "Alınan Kişi: ";
            if (!string.IsNullOrWhiteSpace(cihaz.AlinanKisiAdSoyad))
                alinan += cihaz.AlinanKisiAdSoyad;
            if (!string.IsNullOrWhiteSpace(cihaz.AlinanKisiTelefon))
                alinan += $" ({cihaz.AlinanKisiTelefon})";
            if (alinan == "Alınan Kişi: ")
                alinan = "Alınan Kişi: -";
            lblAlinanKisi.Text = alinan;
            lblAlinanKisi.Visible = !(alinan == "Alınan Kişi: -" || string.IsNullOrWhiteSpace(alinan));

            // Satılan kişi bilgisi
            string satilan = "Satılan Kişi: ";
            if (!string.IsNullOrWhiteSpace(cihaz.SatilanKisiAdSoyad))
                satilan += cihaz.SatilanKisiAdSoyad;
            if (!string.IsNullOrWhiteSpace(cihaz.SatilanKisiTelefon))
                satilan += $" ({cihaz.SatilanKisiTelefon})";
            if (satilan == "Satılan Kişi: ")
                satilan = "Satılan Kişi: -";
            lblSatilanKisi.Text = satilan;
            lblSatilanKisi.Visible = !(satilan == "Satılan Kişi: -" || string.IsNullOrWhiteSpace(satilan));

            YapilacaklariYukle();
            HarcamalariYukle();
            GuncelleKar();
        }

        private void YapilacaklariYukle()
        {
            _yapilacaklar = _context.CihazYapilacaklar
                .Where(y => y.CihazId == _cihaz.Id)
                .OrderBy(y => y.Sira)
                .ToList();

            dataGridViewYapilacaklar.Rows.Clear();
            foreach (var y in _yapilacaklar)
            {
                int rowIndex = dataGridViewYapilacaklar.Rows.Add(
                    y.Id,
                    y.Aciklama,
                    y.Tamamlandi ? "Evet" : "Hayır"
                );
                if (y.Tamamlandi)
                    dataGridViewYapilacaklar.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void HarcamalariYukle()
        {
            _harcamalar = _context.CihazHarcamalar
                .Where(h => h.CihazId == _cihaz.Id)
                .ToList();

            dataGridViewHarcamalar.Rows.Clear();
            foreach (var h in _harcamalar)
            {
                dataGridViewHarcamalar.Rows.Add(
                    h.Id,
                    h.HarcamaAdi,
                    h.Tutar.ToString("C2"),
                    h.Aciklama,
                    h.Tarih.ToString("dd.MM.yyyy HH:mm")
                );
            }
            decimal toplam = _harcamalar.Sum(h => h.Tutar);
            lblToplamHarcama.Text = toplam.ToString("C2");
        }

        private void GuncelleKar()
        {
            decimal toplamHarcama = _harcamalar.Sum(h => h.Tutar);
            decimal kar = _cihaz.SatisFiyati - (_cihaz.AlisMaliyeti + toplamHarcama);
            lblKar.Text = kar.ToString("C2");
            if (kar < 0) lblKar.ForeColor = System.Drawing.Color.Red;
            else lblKar.ForeColor = System.Drawing.Color.Green;
        }

        private void btnYeniGorev_Click(object sender, EventArgs e)
        {
            string aciklama = Microsoft.VisualBasic.Interaction.InputBox("Yapılacak iş açıklaması:", "Yeni Görev");
            if (string.IsNullOrWhiteSpace(aciklama)) return;

            int maxSira = _yapilacaklar.Count > 0 ? _yapilacaklar.Max(y => y.Sira) : 0;
            var yeni = new CihazYapilacak
            {
                CihazId = _cihaz.Id,
                Aciklama = aciklama,
                Tamamlandi = false,
                Sira = maxSira + 1
            };
            _context.CihazYapilacaklar.Add(yeni);
            _context.SaveChanges();
            YapilacaklariYukle();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (dataGridViewYapilacaklar.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewYapilacaklar.CurrentRow.Cells[0].Value);
            var yapilacak = _context.CihazYapilacaklar.Find(id);
            if (yapilacak == null) return;

            if (yapilacak.Tamamlandi)
            {
                MessageBox.Show("Bu görev zaten tamamlanmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            yapilacak.Tamamlandi = true;
            int maxSira = _yapilacaklar.Max(y => y.Sira);
            yapilacak.Sira = maxSira + 1;
            _context.SaveChanges();
            YapilacaklariYukle();
        }

        private void btnGorevSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewYapilacaklar.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewYapilacaklar.CurrentRow.Cells[0].Value);
            var yapilacak = _context.CihazYapilacaklar.Find(id);
            if (yapilacak == null) return;

            _context.CihazYapilacaklar.Remove(yapilacak);
            _context.SaveChanges();
            YapilacaklariYukle();
        }

        private void btnHarcamaEkle_Click(object sender, EventArgs e)
        {
            using (var dialog = new HarcamaDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dialog.Harcama.CihazId = _cihaz.Id;
                    _context.CihazHarcamalar.Add(dialog.Harcama);
                    _context.SaveChanges();
                    HarcamalariYukle();
                    GuncelleKar();
                }
            }
        }

        private void btnStoktanGider_Click(object sender, EventArgs e)
        {
            using (var dialog = new UrunSecimDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK && dialog.SecilenUrun != null)
                {
                    string miktarStr = Microsoft.VisualBasic.Interaction.InputBox("Miktar girin:", "Stoktan Gider", "1");
                    if (!int.TryParse(miktarStr, out int miktar) || miktar <= 0) return;

                    var urun = _context.Urunler.Find(dialog.SecilenUrun.Id);
                    if (urun == null)
                    {
                        MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (urun.StokMiktari < miktar)
                    {
                        MessageBox.Show("Yeterli stok yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal tutar = miktar * urun.AlisFiyati;
                    var harcama = new CihazHarcama
                    {
                        CihazId = _cihaz.Id,
                        HarcamaAdi = urun.UrunAdi,
                        Tutar = tutar,
                        Aciklama = $"Stoktan {miktar} adet alındı. (Alış fiyatı: {urun.AlisFiyati:C2}/adet)",
                        UrunId = urun.Id,
                        Miktar = miktar,
                        Tarih = DateTime.Now
                    };
                    _context.CihazHarcamalar.Add(harcama);

                    urun.StokMiktari -= miktar;
                    var hareket = new StokHareket
                    {
                        UrunId = urun.Id,
                        HareketTipi = "Çıkış",
                        Miktar = miktar,
                        OncekiStok = urun.StokMiktari + miktar,
                        SonrakiStok = urun.StokMiktari,
                        Aciklama = $"{_cihaz.SeriNo} için kullanıldı",
                        Tarih = DateTime.Now,
                        CihazId = _cihaz.Id
                    };
                    _context.StokHareketleri.Add(hareket);

                    _context.SaveChanges();

                    HarcamalariYukle();
                    GuncelleKar();
                }
            }
        }

        private void btnHarcamaDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewHarcamalar.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewHarcamalar.CurrentRow.Cells[0].Value);
            var harcama = _context.CihazHarcamalar.Find(id);
            if (harcama == null) return;

            using (var dialog = new HarcamaDialog(harcama))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(harcama).CurrentValues.SetValues(dialog.Harcama);
                    _context.SaveChanges();
                    HarcamalariYukle();
                    GuncelleKar();
                }
            }
        }

        private void btnHarcamaSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewHarcamalar.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewHarcamalar.CurrentRow.Cells[0].Value);
            var harcama = _context.CihazHarcamalar.Find(id);
            if (harcama == null) return;

            if (MessageBox.Show("Bu harcamayı silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (harcama.UrunId.HasValue && harcama.Miktar > 0)
            {
                var urun = _context.Urunler.Find(harcama.UrunId.Value);
                if (urun != null)
                {
                    urun.StokMiktari += harcama.Miktar;
                    var hareket = new StokHareket
                    {
                        UrunId = urun.Id,
                        HareketTipi = "Giriş",
                        Miktar = harcama.Miktar,
                        OncekiStok = urun.StokMiktari - harcama.Miktar,
                        SonrakiStok = urun.StokMiktari,
                        Aciklama = $"{_cihaz.SeriNo} harcaması silindi - {harcama.HarcamaAdi}",
                        Tarih = DateTime.Now,
                        CihazId = _cihaz.Id
                    };
                    _context.StokHareketleri.Add(hareket);
                }
            }

            _context.CihazHarcamalar.Remove(harcama);
            _context.SaveChanges();

            HarcamalariYukle();
            GuncelleKar();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CihazDetayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}