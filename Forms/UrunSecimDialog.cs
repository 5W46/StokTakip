using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;
using StokTakip.Helpers;

namespace StokTakip.Forms
{
    public partial class UrunSecimDialog : Form
    {
        private AppDbContext _context;
        public Urun? SecilenUrun { get; private set; }

        public UrunSecimDialog()
        {
            InitializeComponent();
            _context = new AppDbContext();
            UrunleriYukle("");
        }

        private void UrunleriYukle(string filter)
        {
            var allUrunler = _context.Urunler.ToList();
            string normalizedFilter = NormalizeTurkish(filter);

            var filtered = allUrunler
                .Where(u => string.IsNullOrEmpty(filter) ||
                            NormalizeTurkish(u.UrunAdi).Contains(normalizedFilter) ||
                            (u.Barkod != null && NormalizeTurkish(u.Barkod).Contains(normalizedFilter)))
                .OrderBy(u => u.UrunAdi)
                .ToList();

            dataGridViewUrunler.Rows.Clear();
            foreach (var u in filtered)
            {
                int rowIndex = dataGridViewUrunler.Rows.Add(
                    u.Id,
                    u.Barkod,
                    u.UrunAdi,
                    u.SatisFiyati.ToString("C2")
                );
                if (!string.IsNullOrEmpty(u.FotografYolu))
                {
                    var img = FileHelper.GetProductThumbnail(u.FotografYolu);
                    if (img != null)
                        dataGridViewUrunler.Rows[rowIndex].Cells[4].Value = img;
                }
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
            UrunleriYukle(txtAra.Text.Trim());
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridViewUrunler.CurrentRow.Cells[0].Value);
            SecilenUrun = _context.Urunler.Find(id);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Dispose metodu burada YOK – sadece Designer.cs'de olmalı
    }
}