using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilLotListForm : Form
    {
        private AppDbContext _context;

        public PilLotListForm()
        {
            InitializeComponent();
            Text = "Batarya İşlemleri";
            _context = new AppDbContext();
            LotlariYukle();
            BataryalariYukle();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            UpdateButtonsForTab();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonsForTab();
        }

        private void UpdateButtonsForTab()
        {
            bool isLotTab = tabControl1.SelectedIndex == 0;
            btnBataryaGrupla.Visible = isLotTab;
            btnSatildi.Visible = !isLotTab;
        }

        private void LotlariYukle()
        {
            var lots = _context.PilLotlari
                .OrderByDescending(l => l.GirisTarihi)
                .ToList();

            dataGridViewLots.Rows.Clear();
            foreach (var lot in lots)
            {
                int adetStokta = _context.PilHucres.Count(h => h.LotId == lot.Id && h.Durum == "Stokta");
                dataGridViewLots.Rows.Add(
                    lot.Id,
                    lot.LotAdi,
                    lot.HucreModel,
                    lot.Adet,
                    adetStokta,
                    lot.BirimMaliyet.ToString("C2"),
                    lot.GirisTarihi.ToString("dd.MM.yyyy"),
                    lot.SifirPilMi ? "Sıfır" : "Çıkma"
                );
            }
        }

        private void BataryalariYukle()
        {
            var bataryalar = _context.PilBataryalar
                .OrderByDescending(b => b.OlusturmaTarihi)
                .ToList();

            dataGridViewBataryalar.Rows.Clear();
            foreach (var b in bataryalar)
            {
                dataGridViewBataryalar.Rows.Add(
                    b.Id,
                    b.BataryaAdi,
                    $"{b.SeriSayisi}S{b.ParalelSayisi}P",
                    b.ToplamKapasite.ToString("F0"),
                    b.ToplamMaliyet.ToString("C2"),
                    b.SatisFiyati.ToString("C2"),
                    b.Kar.ToString("C2"),
                    b.Durum,
                    b.OlusturmaTarihi.ToString("dd.MM.yyyy")
                );
            }
        }

        private void btnYeniLot_Click(object sender, EventArgs e)
        {
            using (var dialog = new PilLotDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.PilLotlari.Add(dialog.Lot);
                    _context.SaveChanges();
                    LotlariYukle();
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Pil Lotları sekmesi
            {
                if (dataGridViewLots.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridViewLots.CurrentRow.Cells[0].Value);
                var lot = _context.PilLotlari.Find(id);
                if (lot == null) return;

                using (var dialog = new PilLotDialog(lot))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        _context.Entry(lot).CurrentValues.SetValues(dialog.Lot);
                        _context.SaveChanges();
                        LotlariYukle();
                    }
                }
            }
            else // Yapılmış bataryalar sekmesi
            {
                if (dataGridViewBataryalar.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridViewBataryalar.CurrentRow.Cells[0].Value);
                var batarya = _context.PilBataryalar.Find(id);
                if (batarya == null) return;

                using (var dialog = new PilBataryaDetayForm(batarya))
                {
                    dialog.ShowDialog();
                    BataryalariYukle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Pil Lotları
            {
                if (dataGridViewLots.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridViewLots.CurrentRow.Cells[0].Value);
                var lot = _context.PilLotlari.Find(id);
                if (lot == null) return;

                bool kullanilmis = _context.PilHucres.Any(h => h.LotId == id && h.Durum != "Stokta");
                if (kullanilmis)
                {
                    MessageBox.Show("Bu lotta kullanılmış veya bataryaya eklenmiş hücreler var. Silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bu lotu silmek istediğinize emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var hucres = _context.PilHucres.Where(h => h.LotId == id);
                    _context.PilHucres.RemoveRange(hucres);
                    _context.PilLotlari.Remove(lot);
                    _context.SaveChanges();
                    LotlariYukle();
                }
            }
            else // Yapılmış bataryalar
            {
                if (dataGridViewBataryalar.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridViewBataryalar.CurrentRow.Cells[0].Value);
                var batarya = _context.PilBataryalar.Find(id);
                if (batarya == null) return;

                if (MessageBox.Show("Bu bataryayı silmek istediğinize emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var baglantilar = _context.PilBataryaHucres.Where(bh => bh.BataryaId == id);
                    _context.PilBataryaHucres.RemoveRange(baglantilar);
                    _context.PilBataryalar.Remove(batarya);
                    _context.SaveChanges();
                    BataryalariYukle();
                }
            }
        }

        private void btnBataryaGrupla_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (dataGridViewLots.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen bir lot seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int lotId = Convert.ToInt32(dataGridViewLots.CurrentRow.Cells[0].Value);
                var lot = _context.PilLotlari.Find(lotId);
                if (lot == null) return;

                using (var gruplamaForm = new PilGruplamaForm(lot))
                {
                    gruplamaForm.ShowDialog();
                    LotlariYukle();
                    BataryalariYukle();
                }
            }
            else
            {
                MessageBox.Show("Batarya gruplama işlemi için lütfen Pil Lotları sekmesinden bir lot seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSatildi_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 1) return;
            if (dataGridViewBataryalar.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewBataryalar.CurrentRow.Cells[0].Value);
            var batarya = _context.PilBataryalar.Find(id);
            if (batarya == null) return;

            if (batarya.Durum == "Satıldı")
            {
                MessageBox.Show("Bu batarya zaten satılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dialog = new BataryaSatisDialog(batarya.SatisFiyati))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    batarya.SatisFiyati = dialog.SatisFiyati;
                    batarya.Durum = "Satıldı";
                    batarya.SatisTarihi = DateTime.Now;
                    batarya.SatilanKisiAdSoyad = string.IsNullOrWhiteSpace(dialog.AliciAdSoyad) ? null : dialog.AliciAdSoyad.Trim();
                    batarya.SatilanKisiTelefon = string.IsNullOrWhiteSpace(dialog.AliciTelefon) ? null : dialog.AliciTelefon.Trim();

                    _context.SaveChanges();
                    BataryalariYukle();
                }
            }
        }

        private void dataGridViewLots_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridViewLots.Rows[e.RowIndex].Cells[0].Value);
            var lot = _context.PilLotlari.Find(id);
            if (lot != null)
            {
                using (var form = new PilLotDetayForm(lot))
                {
                    form.ShowDialog();
                    LotlariYukle(); // Stok sayısı güncellenebilir
                }
            }
        }

        private void dataGridViewBataryalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridViewBataryalar.Rows[e.RowIndex].Cells[0].Value);
            var batarya = _context.PilBataryalar.Find(id);
            if (batarya != null)
            {
                using (var form = new PilBataryaDetayForm(batarya))
                {
                    form.ShowDialog();
                }
            }
        }

        private void PilLotListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}