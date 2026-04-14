using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class MusteriSecimDialog : Form
    {
        private AppDbContext _context;
        public Musteri? SecilenMusteri { get; private set; }

        public MusteriSecimDialog()
        {
            InitializeComponent();
            _context = new AppDbContext();
            MusterileriYukle("");
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
            MusterileriYukle(txtAra.Text.Trim());
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (dataGridViewMusteriler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridViewMusteriler.CurrentRow.Cells[0].Value);
            SecilenMusteri = _context.Musteriler.Find(id);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
            _context?.Dispose();
        }
    }
}