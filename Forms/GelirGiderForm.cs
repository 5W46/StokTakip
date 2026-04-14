using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class GelirGiderForm : Form
    {
        private AppDbContext _context;
        private string _aktifFiltre = "Tüm İşlemler";

        public GelirGiderForm()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
            _context = new AppDbContext();
            cmbFiltre.SelectedIndex = 0;
            RaporuGuncelle();
            GiderleriYukle();
            IslemleriYukle();
        }

        private void RaporuGuncelle()
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            // Gelirler
            decimal urunSatisGelirleri = _context.Satislar
                .Where(s => s.SatisTarihi >= baslangic && s.SatisTarihi <= bitis)
                .Sum(s => s.ToplamTutar);

            decimal scooterSatisGelirleri = _context.Cihazlar
                .Where(c => c.Durum == "Satıldı" && c.SatisTarihi >= baslangic && c.SatisTarihi <= bitis)
                .Sum(c => c.SatisFiyati);

            decimal bataryaSatisGelirleri = _context.PilBataryalar
                .Where(b => b.Durum == "Satıldı" && b.SatisTarihi >= baslangic && b.SatisTarihi <= bitis)
                .Sum(b => b.SatisFiyati);

            decimal toplamGelir = urunSatisGelirleri + scooterSatisGelirleri + bataryaSatisGelirleri;

            // Giderler
            decimal manuelGiderler = _context.Giderler
                .Where(g => g.GiderTarihi >= baslangic && g.GiderTarihi <= bitis)
                .Sum(g => g.Tutar);

            decimal scooterAlisGiderleri = _context.Cihazlar
                .Where(c => c.CreatedAt >= baslangic && c.CreatedAt <= bitis)
                .Sum(c => c.AlisMaliyeti);

            decimal stokGirisGiderleri = _context.StokHareketleri
                .Include(h => h.Urun)
                .Where(h => h.HareketTipi == "Giriş" && h.Tarih >= baslangic && h.Tarih <= bitis)
                .Sum(h => h.Miktar * (h.Urun != null ? h.Urun.AlisFiyati : 0));

            decimal bataryaUretimGiderleri = _context.PilBataryalar
                .Where(b => b.OlusturmaTarihi >= baslangic && b.OlusturmaTarihi <= bitis)
                .Sum(b => (b.SarfMalzemeler + b.Isçilik));

            decimal disParcaGiderleri = _context.CihazDisParcalar
                .Where(dp => dp.Tarih >= baslangic && dp.Tarih <= bitis)
                .Sum(dp => dp.ToplamMaliyet);

            decimal toplamGider = manuelGiderler + scooterAlisGiderleri + stokGirisGiderleri +
                                   bataryaUretimGiderleri + disParcaGiderleri;

            decimal netKar = toplamGelir - toplamGider;

            lblToplamGelir.Text = toplamGelir.ToString("C2");
            lblToplamGider.Text = toplamGider.ToString("C2");
            lblNetKar.Text = netKar.ToString("C2");

            if (netKar < 0)
                lblNetKar.ForeColor = System.Drawing.Color.Red;
            else
                lblNetKar.ForeColor = System.Drawing.Color.Green;
        }

        private void GiderleriYukle()
        {
            var giderler = _context.Giderler
                .OrderByDescending(g => g.GiderTarihi)
                .ToList();

            dataGridViewGiderler.Rows.Clear();
            foreach (var g in giderler)
            {
                dataGridViewGiderler.Rows.Add(
                    g.Id,
                    g.GiderTarihi.ToString("dd.MM.yyyy"),
                    g.Kategori,
                    g.Aciklama,
                    g.Tutar.ToString("C2")
                );
            }
        }

        private void IslemleriYukle()
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);
            _aktifFiltre = cmbFiltre.SelectedItem?.ToString() ?? "Tüm İşlemler";

            var islemler = new List<Islem>();

            // 1. Ürün satışları (Gelir)
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Gelirler" || _aktifFiltre == "Stok İşlemleri")
            {
                var satislar = _context.Satislar
                    .Include(s => s.Musteri)
                    .Where(s => s.SatisTarihi >= baslangic && s.SatisTarihi <= bitis)
                    .Select(s => new Islem
                    {
                        Tarih = s.SatisTarihi,
                        Tur = "Gelir",
                        Aciklama = $"Ürün Satışı #{s.Id} - {s.Musteri.Ad} {s.Musteri.Soyad}",
                        Tutar = s.ToplamTutar,
                        Renk = System.Drawing.Color.Green
                    })
                    .ToList();
                islemler.AddRange(satislar);
            }

            // 2. Scooter satışları (Gelir)
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Gelirler" || _aktifFiltre == "Scooter İşlemleri")
            {
                var scooterSatislar = _context.Cihazlar
                    .Where(c => c.Durum == "Satıldı" && c.SatisTarihi >= baslangic && c.SatisTarihi <= bitis)
                    .Select(c => new Islem
                    {
                        Tarih = c.SatisTarihi.Value,
                        Tur = "Gelir",
                        Aciklama = $"Scooter Satışı - {c.MarkaModel} (Seri No: {c.SeriNo})",
                        Tutar = c.SatisFiyati,
                        Renk = System.Drawing.Color.Green
                    })
                    .ToList();
                islemler.AddRange(scooterSatislar);
            }

            // 3. Batarya satışları (Gelir)
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Gelirler" || _aktifFiltre == "Batarya İşlemleri")
            {
                var bataryaSatislar = _context.PilBataryalar
                    .Where(b => b.Durum == "Satıldı" && b.SatisTarihi >= baslangic && b.SatisTarihi <= bitis)
                    .Select(b => new Islem
                    {
                        Tarih = b.SatisTarihi.Value,
                        Tur = "Gelir",
                        Aciklama = $"Batarya Satışı - {b.BataryaAdi}",
                        Tutar = b.SatisFiyati,
                        Renk = System.Drawing.Color.Green
                    })
                    .ToList();
                islemler.AddRange(bataryaSatislar);
            }

            // 4. Scooter alışları (Gider)
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Giderler" || _aktifFiltre == "Scooter İşlemleri")
            {
                var scooterAlislar = _context.Cihazlar
                    .Where(c => c.CreatedAt >= baslangic && c.CreatedAt <= bitis)
                    .Select(c => new Islem
                    {
                        Tarih = c.CreatedAt,
                        Tur = "Gider",
                        Aciklama = $"Scooter Alışı - {c.MarkaModel} (Seri No: {c.SeriNo})",
                        Tutar = c.AlisMaliyeti,
                        Renk = System.Drawing.Color.Red
                    })
                    .ToList();
                islemler.AddRange(scooterAlislar);
            }

            // 5. Stok girişleri (Gider - ürün alış maliyeti)
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Giderler" || _aktifFiltre == "Stok İşlemleri")
            {
                var stokGirisleri = _context.StokHareketleri
                    .Include(h => h.Urun)
                    .Where(h => h.HareketTipi == "Giriş" && h.Tarih >= baslangic && h.Tarih <= bitis)
                    .Select(h => new Islem
                    {
                        Tarih = h.Tarih,
                        Tur = "Gider",
                        Aciklama = $"Stok Girişi - {h.Urun.UrunAdi} x{h.Miktar}",
                        Tutar = h.Miktar * h.Urun.AlisFiyati,
                        Renk = System.Drawing.Color.Red
                    })
                    .ToList();
                islemler.AddRange(stokGirisleri);
            }

            // 6. Batarya üretim maliyetleri (Gider - sadece sarf + işçilik)
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Giderler" || _aktifFiltre == "Batarya İşlemleri")
            {
                var bataryaUretimler = _context.PilBataryalar
                    .Where(b => b.OlusturmaTarihi >= baslangic && b.OlusturmaTarihi <= bitis &&
                                (b.SarfMalzemeler > 0 || b.Isçilik > 0))
                    .Select(b => new Islem
                    {
                        Tarih = b.OlusturmaTarihi,
                        Tur = "Gider",
                        Aciklama = $"Batarya Üretimi - {b.BataryaAdi} (Sarf + İşçilik)",
                        Tutar = b.SarfMalzemeler + b.Isçilik,
                        Renk = System.Drawing.Color.Red
                    })
                    .ToList();
                islemler.AddRange(bataryaUretimler);
            }

            // 7. Dışarıdan temin edilen scooter parçaları (Gider)
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Giderler" || _aktifFiltre == "Scooter İşlemleri")
            {
                var disParcalar = _context.CihazDisParcalar
                    .Include(dp => dp.Cihaz)
                    .Where(dp => dp.Tarih >= baslangic && dp.Tarih <= bitis)
                    .Select(dp => new Islem
                    {
                        Tarih = dp.Tarih,
                        Tur = "Gider",
                        Aciklama = dp.Cihaz != null
                            ? $"Dış Parça - {dp.ParcaAdi} (x{dp.Miktar}) - Scooter: {dp.Cihaz.MarkaModel}"
                            : $"Dış Parça - {dp.ParcaAdi} (x{dp.Miktar})",
                        Tutar = dp.ToplamMaliyet,
                        Renk = System.Drawing.Color.Red
                    })
                    .ToList();
                islemler.AddRange(disParcalar);
            }

            // 8. Manuel giderler
            if (_aktifFiltre == "Tüm İşlemler" || _aktifFiltre == "Sadece Giderler" || _aktifFiltre == "Manuel Giderler")
            {
                var manuelGiderler = _context.Giderler
                    .Where(g => g.GiderTarihi >= baslangic && g.GiderTarihi <= bitis)
                    .Select(g => new Islem
                    {
                        Tarih = g.GiderTarihi,
                        Tur = "Gider",
                        Aciklama = $"{g.Kategori} - {g.Aciklama}",
                        Tutar = g.Tutar,
                        Renk = System.Drawing.Color.Red
                    })
                    .ToList();
                islemler.AddRange(manuelGiderler);
            }

            // Tarihe göre sırala (en yeni üstte)
            islemler = islemler.OrderByDescending(i => i.Tarih).ToList();

            dataGridViewIslemler.Rows.Clear();
            foreach (var i in islemler)
            {
                int rowIndex = dataGridViewIslemler.Rows.Add(
                    i.Tarih.ToString("dd.MM.yyyy HH:mm"),
                    i.Tur,
                    i.Aciklama,
                    i.Tutar.ToString("C2")
                );
                dataGridViewIslemler.Rows[rowIndex].DefaultCellStyle.ForeColor = i.Renk;
                if (i.Tur == "Gider")
                    dataGridViewIslemler.Rows[rowIndex].DefaultCellStyle.Font = new System.Drawing.Font(dataGridViewIslemler.Font, System.Drawing.FontStyle.Bold);
            }
        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            IslemleriYukle();
        }

        private void btnYeniGider_Click(object sender, EventArgs e)
        {
            using (var dialog = new GiderDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Giderler.Add(dialog.Gider);
                    _context.SaveChanges();
                    GiderleriYukle();
                    RaporuGuncelle();
                    IslemleriYukle();
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewGiderler.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewGiderler.CurrentRow.Cells[0].Value);
            var gider = _context.Giderler.Find(id);
            if (gider == null) return;

            using (var dialog = new GiderDialog(gider))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(gider).CurrentValues.SetValues(dialog.Gider);
                    _context.SaveChanges();
                    GiderleriYukle();
                    RaporuGuncelle();
                    IslemleriYukle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewGiderler.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewGiderler.CurrentRow.Cells[0].Value);
            var gider = _context.Giderler.Find(id);
            if (gider == null) return;

            if (MessageBox.Show("Bu gideri silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _context.Giderler.Remove(gider);
                _context.SaveChanges();
                GiderleriYukle();
                RaporuGuncelle();
                IslemleriYukle();
            }
        }

        private void btnRaporGuncelle_Click(object sender, EventArgs e)
        {
            RaporuGuncelle();
            IslemleriYukle();
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            RaporuGuncelle();
            IslemleriYukle();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            RaporuGuncelle();
            IslemleriYukle();
        }

        private void btnPdfCikti_Click(object sender, EventArgs e)
        {
            var islemler = new List<Islem>();
            foreach (DataGridViewRow row in dataGridViewIslemler.Rows)
            {
                if (row.IsNewRow) continue;
                islemler.Add(new Islem
                {
                    Tarih = DateTime.Parse(row.Cells[0].Value?.ToString() ?? ""),
                    Tur = row.Cells[1].Value?.ToString() ?? "",
                    Aciklama = row.Cells[2].Value?.ToString() ?? "",
                    Tutar = decimal.Parse(row.Cells[3].Value?.ToString() ?? "0", System.Globalization.NumberStyles.Currency)
                });
            }

            var baslangic = dtpBaslangic.Value;
            var bitis = dtpBitis.Value;

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.Header().Text("Gelir/Gider Raporu (Detaylı İşlem Geçmişi)").FontSize(20).Bold();
                    page.Content().Column(col =>
                    {
                        col.Item().Text($"Tarih Aralığı: {baslangic:dd.MM.yyyy} - {bitis:dd.MM.yyyy}").FontSize(12);
                        col.Item().Text($"Filtre: {_aktifFiltre}").FontSize(12);
                        col.Item().LineHorizontal(1);
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1.2f);   // Tarih
                                columns.RelativeColumn(0.8f);   // Tür
                                columns.RelativeColumn(5.0f);   // Açıklama
                                columns.RelativeColumn(1.2f);   // Tutar
                            });

                            table.Header(header =>
                            {
                                header.Cell().Text("Tarih").Bold();
                                header.Cell().Text("Tür").Bold();
                                header.Cell().Text("Açıklama").Bold();
                                header.Cell().Text("Tutar").Bold();
                            });

                            foreach (var islem in islemler)
                            {
                                table.Cell().Text(islem.Tarih.ToString("dd.MM.yyyy HH:mm"));
                                table.Cell().Text(islem.Tur);
                                table.Cell().Text(islem.Aciklama);
                                table.Cell().Text(islem.Tutar.ToString("C2"));
                            }
                        });
                        col.Item().LineHorizontal(1);
                        col.Item().Text($"Toplam Gelir: {lblToplamGelir.Text}").FontSize(10);
                        col.Item().Text($"Toplam Gider: {lblToplamGider.Text}").FontSize(10);
                        col.Item().Text($"Net Kar/Zarar: {lblNetKar.Text}").FontSize(12).Bold();
                    });
                });
            });

            using var saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF dosyası (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                FileName = $"GelirGider_Detayli_Rapor_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                document.GeneratePdf(saveFileDialog.FileName);
                MessageBox.Show("Rapor PDF olarak kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GelirGiderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }

    internal class Islem
    {
        public DateTime Tarih { get; set; }
        public string Tur { get; set; } = string.Empty;
        public string Aciklama { get; set; } = string.Empty;
        public decimal Tutar { get; set; }
        public System.Drawing.Color Renk { get; set; }
    }
}