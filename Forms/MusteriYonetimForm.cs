using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class MusteriYonetimForm : Form
    {
        private AppDbContext _context;
        private string _currentFilter = "";
        private bool _isDetailOpen = false;
        private DateTime _lastOpenTime = DateTime.MinValue;

        public MusteriYonetimForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            MusterileriYukle("");
            dataGridViewSiparisler.CellDoubleClick += dataGridViewSiparisler_CellDoubleClick;
        }

        private void MusterileriYukle(string filter)
        {
            var allMusteriler = _context.Musteriler.ToList();
            string normalizedFilter = NormalizeTurkish(filter);

            var filtered = allMusteriler
                .Where(m => string.IsNullOrEmpty(filter) ||
                            NormalizeTurkish(m.Ad ?? "").Contains(normalizedFilter) ||
                            NormalizeTurkish(m.Soyad ?? "").Contains(normalizedFilter) ||
                            NormalizeTurkish(m.Telefon ?? "").Contains(normalizedFilter))
                .OrderBy(m => m.Ad).ThenBy(m => m.Soyad)
                .ToList();

            dataGridViewMusteriler.Rows.Clear();
            foreach (var m in filtered)
            {
                dataGridViewMusteriler.Rows.Add(
                    m.Id,
                    m.Ad ?? "",
                    m.Soyad ?? "",
                    m.Telefon ?? "",
                    m.Email ?? "",
                    m.Adres ?? ""
                );
            }
        }

        private string NormalizeTurkish(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;
            return text.ToLower()
                .Replace('ı', 'i')
                .Replace('ğ', 'g')
                .Replace('ü', 'u')
                .Replace('ş', 's')
                .Replace('ö', 'o')
                .Replace('ç', 'c');
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            _currentFilter = txtAra.Text.Trim();
            MusterileriYukle(_currentFilter);
        }

        private void dataGridViewMusteriler_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMusteriler.CurrentRow != null && dataGridViewMusteriler.CurrentRow.Cells[0].Value != null)
            {
                int id = Convert.ToInt32(dataGridViewMusteriler.CurrentRow.Cells[0].Value);
                SiparisleriYukle(id);
            }
        }

        private void SiparisleriYukle(int musteriId)
        {
            var satislar = _context.Satislar
                .Where(s => s.MusteriId == musteriId)
                .Include(s => s.Detaylar)
                .ThenInclude(d => d.Urun)
                .OrderByDescending(s => s.SatisTarihi)
                .ToList();

            dataGridViewSiparisler.Rows.Clear();
            foreach (var s in satislar)
            {
                string detaylar = string.Join(", ", s.Detaylar.Select(d => $"{d.Miktar}x {d.Urun?.UrunAdi ?? "?"}"));
                dataGridViewSiparisler.Rows.Add(
                    s.Id,
                    s.SatisTarihi.ToString("dd.MM.yyyy HH:mm"),
                    s.ToplamTutar.ToString("C2"),
                    s.KargoTakipNo ?? "",
                    detaylar
                );
            }
        }

        private void dataGridViewSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satır dışı tıklamayı engelle
            if (e.RowIndex < 0) return;

            // Aynı anda iki açılmayı engelle
            if (_isDetailOpen) return;

            // Son açılıştan çok kısa süre geçtiyse ikinci kez açılmayı engelle
            if ((DateTime.Now - _lastOpenTime).TotalMilliseconds < 500)
                return;

            int satisId = Convert.ToInt32(dataGridViewSiparisler.Rows[e.RowIndex].Cells[0].Value);
            _isDetailOpen = true;
            _lastOpenTime = DateTime.Now;

            var detayForm = new SiparisDetayForm(satisId);
            detayForm.FormClosed += (s, args) =>
            {
                _isDetailOpen = false;
                if (dataGridViewMusteriler.CurrentRow != null)
                {
                    int musteriId = Convert.ToInt32(dataGridViewMusteriler.CurrentRow.Cells[0].Value);
                    SiparisleriYukle(musteriId);
                }
            };
            detayForm.ShowDialog();
        }

        // Diğer metodlar (btnYeniMusteri_Click, btnDuzenle_Click, btnSil_Click, btnKapat_Click, MusteriYonetimForm_FormClosing) aynen kalır.
        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            using (var dialog = new MusteriDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Musteriler.Add(dialog.Musteri);
                    _context.SaveChanges();
                    MusterileriYukle(_currentFilter);
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewMusteriler.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewMusteriler.CurrentRow.Cells[0].Value);
            var musteri = _context.Musteriler.Find(id);
            if (musteri == null) return;

            using (var dialog = new MusteriDialog(musteri))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(musteri).CurrentValues.SetValues(dialog.Musteri);
                    _context.SaveChanges();
                    MusterileriYukle(_currentFilter);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewMusteriler.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewMusteriler.CurrentRow.Cells[0].Value);
            var musteri = _context.Musteriler.Find(id);
            if (musteri == null) return;

            if (MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _context.Musteriler.Remove(musteri);
                _context.SaveChanges();
                MusterileriYukle(_currentFilter);
                dataGridViewSiparisler.Rows.Clear();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MusteriYonetimForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}