using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class CihazYapilacakDialog : Form
    {
        private AppDbContext _context;
        private int _cihazId;
        private List<CihazYapilacak> _yapilacaklar = new List<CihazYapilacak>();

        public CihazYapilacakDialog(int cihazId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _cihazId = cihazId;
            YapilacaklariYukle();
        }

        private void YapilacaklariYukle()
        {
            _yapilacaklar = _context.CihazYapilacaklar
                .Where(y => y.CihazId == _cihazId)
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

        private void btnYeni_Click(object sender, EventArgs e)
        {
            string aciklama = Microsoft.VisualBasic.Interaction.InputBox("Yapılacak iş açıklaması:", "Yeni Görev");
            if (string.IsNullOrWhiteSpace(aciklama)) return;

            int maxSira = _yapilacaklar.Count > 0 ? _yapilacaklar.Max(y => y.Sira) : 0;
            var yeni = new CihazYapilacak
            {
                CihazId = _cihazId,
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewYapilacaklar.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewYapilacaklar.CurrentRow.Cells[0].Value);
            var yapilacak = _context.CihazYapilacaklar.Find(id);
            if (yapilacak == null) return;

            _context.CihazYapilacaklar.Remove(yapilacak);
            _context.SaveChanges();
            YapilacaklariYukle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CihazYapilacakDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}