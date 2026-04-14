using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class CihazForm : Form
    {
        private AppDbContext _context;
        private string _aktifFiltre = "";
        private string _satilmisFiltre = "";

        public CihazForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            CihazlariYukle();
            dataGridViewAktif.CellDoubleClick += DataGridViewAktif_CellDoubleClick;
            dataGridViewSatilmis.CellDoubleClick += DataGridViewSatilmis_CellDoubleClick;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool aktifSecili = tabControl1.SelectedIndex == 0;
            btnSatildi.Visible = aktifSecili;
            btnAktifeTasi.Visible = !aktifSecili;
        }

        private void CihazlariYukle()
        {
            // Aktif cihazlar
            var aktifCihazlar = _context.Cihazlar
                .Include(c => c.Harcamalar)
                .Where(c => c.Durum != "Satıldı")
                .OrderByDescending(c => c.Id)
                .ToList();

            if (!string.IsNullOrEmpty(_aktifFiltre))
            {
                string lowerFilter = _aktifFiltre.ToLower();
                aktifCihazlar = aktifCihazlar
                    .Where(c => c.MarkaModel.ToLower().Contains(lowerFilter) ||
                                c.SeriNo.ToLower().Contains(lowerFilter))
                    .ToList();
            }

            dataGridViewAktif.Rows.Clear();
            foreach (var c in aktifCihazlar)
            {
                decimal toplamHarcama = c.Harcamalar.Sum(h => h.Tutar);
                decimal kar = c.SatisFiyati - (c.AlisMaliyeti + toplamHarcama);
                dataGridViewAktif.Rows.Add(
                    c.Id,
                    c.MarkaModel,
                    c.SeriNo,
                    c.Durum,
                    c.AlisMaliyeti.ToString("C2"),
                    c.SatisFiyati.ToString("C2"),
                    kar.ToString("C2"),
                    c.CreatedAt.ToString("dd.MM.yyyy")
                );
            }

            // Satılmış cihazlar (harcamaları da ekleyerek kar hesapla)
            var satilmisCihazlar = _context.Cihazlar
                .Include(c => c.Harcamalar)
                .Where(c => c.Durum == "Satıldı")
                .OrderByDescending(c => c.SatisTarihi)
                .ToList();

            if (!string.IsNullOrEmpty(_satilmisFiltre))
            {
                string lowerFilter = _satilmisFiltre.ToLower();
                satilmisCihazlar = satilmisCihazlar
                    .Where(c => c.MarkaModel.ToLower().Contains(lowerFilter) ||
                                c.SeriNo.ToLower().Contains(lowerFilter))
                    .ToList();
            }

            dataGridViewSatilmis.Rows.Clear();
            foreach (var c in satilmisCihazlar)
            {
                decimal toplamHarcama = c.Harcamalar.Sum(h => h.Tutar);
                decimal kar = c.SatisFiyati - (c.AlisMaliyeti + toplamHarcama);
                dataGridViewSatilmis.Rows.Add(
                    c.Id,
                    c.MarkaModel,
                    c.SeriNo,
                    c.SatisFiyati.ToString("C2"),
                    kar.ToString("C2"),
                    c.SatisTarihi?.ToString("dd.MM.yyyy") ?? "-"
                );
            }
        }

        private void txtAktifAra_TextChanged(object sender, EventArgs e)
        {
            _aktifFiltre = txtAktifAra.Text.Trim();
            CihazlariYukle();
        }

        private void txtSatilmisAra_TextChanged(object sender, EventArgs e)
        {
            _satilmisFiltre = txtSatilmisAra.Text.Trim();
            CihazlariYukle();
        }

        private void DataGridViewAktif_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridViewAktif.Rows[e.RowIndex].Cells[0].Value);
            var cihaz = _context.Cihazlar
                .Include(c => c.Harcamalar)
                .Include(c => c.Yapilacaklar)
                .FirstOrDefault(c => c.Id == id);
            if (cihaz != null)
            {
                using (var detayForm = new CihazDetayForm(cihaz))
                {
                    detayForm.ShowDialog();
                    CihazlariYukle();
                }
            }
        }

        private void DataGridViewSatilmis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridViewSatilmis.Rows[e.RowIndex].Cells[0].Value);
            var cihaz = _context.Cihazlar
                .Include(c => c.Harcamalar)
                .Include(c => c.Yapilacaklar)
                .FirstOrDefault(c => c.Id == id);
            if (cihaz != null)
            {
                using (var detayForm = new CihazDetayForm(cihaz))
                {
                    detayForm.ShowDialog();
                    CihazlariYukle();
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var dialog = new CihazDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Cihazlar.Add(dialog.Cihaz);
                    _context.SaveChanges();
                    CihazlariYukle();
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DataGridView selectedGrid = tabControl1.SelectedIndex == 0 ? dataGridViewAktif : dataGridViewSatilmis;
            if (selectedGrid.CurrentRow == null) return;

            int id = Convert.ToInt32(selectedGrid.CurrentRow.Cells[0].Value);
            var cihaz = _context.Cihazlar.Find(id);
            if (cihaz == null) return;

            using (var dialog = new CihazDialog(cihaz))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(cihaz).CurrentValues.SetValues(dialog.Cihaz);
                    _context.SaveChanges();
                    CihazlariYukle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridView selectedGrid = tabControl1.SelectedIndex == 0 ? dataGridViewAktif : dataGridViewSatilmis;
            if (selectedGrid.CurrentRow == null) return;

            int id = Convert.ToInt32(selectedGrid.CurrentRow.Cells[0].Value);
            var cihaz = _context.Cihazlar.Find(id);
            if (cihaz == null) return;

            if (MessageBox.Show("Bu cihazı silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _context.Cihazlar.Remove(cihaz);
                _context.SaveChanges();
                CihazlariYukle();
            }
        }

        private void btnSatildi_Click(object sender, EventArgs e)
        {
            if (dataGridViewAktif.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewAktif.CurrentRow.Cells[0].Value);
            var cihaz = _context.Cihazlar.Find(id);
            if (cihaz == null) return;

            if (cihaz.Durum == "Satıldı")
            {
                MessageBox.Show("Cihaz zaten satılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dialog = new SatisBilgileriDialog(cihaz.SatisFiyati))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    cihaz.SatisFiyati = dialog.SatisFiyati;
                    cihaz.Durum = "Satıldı";
                    cihaz.SatisTarihi = DateTime.Now;
                    cihaz.SatilanKisiAdSoyad = string.IsNullOrWhiteSpace(dialog.AliciAdSoyad) ? null : dialog.AliciAdSoyad.Trim();
                    cihaz.SatilanKisiTelefon = string.IsNullOrWhiteSpace(dialog.AliciTelefon) ? null : dialog.AliciTelefon.Trim();
                    _context.SaveChanges();
                    CihazlariYukle();
                }
            }
        }

        private void btnAktifeTasi_Click(object sender, EventArgs e)
        {
            if (dataGridViewSatilmis.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewSatilmis.CurrentRow.Cells[0].Value);
            var cihaz = _context.Cihazlar.Find(id);
            if (cihaz == null) return;

            if (MessageBox.Show("Cihazı aktif cihazlara taşımak istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cihaz.Durum = "Satışa hazır";
                cihaz.SatisTarihi = null;
                cihaz.SatilanKisiAdSoyad = null;
                cihaz.SatilanKisiTelefon = null;
                _context.SaveChanges();
                CihazlariYukle();
            }
        }

        private void CihazForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}