using System;
using System.Linq;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilLotDialog : Form
    {
        private AppDbContext _context;
        public PilLot Lot { get; private set; }
        private bool _sifirPil;

        public PilLotDialog(PilLot? existing = null)
        {
            InitializeComponent();
            _context = new AppDbContext();
            if (existing != null)
            {
                Lot = existing;
                txtLotAdi.Text = existing.LotAdi;
                txtHucreModel.Text = existing.HucreModel;
                txtTedarikciAdi.Text = existing.TedarikciAdi;
                txtTedarikciTelefon.Text = existing.TedarikciTelefon;
                txtBirimMaliyet.Text = existing.BirimMaliyet.ToString();
                numericAdet.Value = existing.Adet;
                chkSifirPil.Checked = existing.SifirPilMi;
                txtNotlar.Text = existing.Notlar;
            }
            else
            {
                Lot = new PilLot();
            }

            _sifirPil = chkSifirPil.Checked;
            HuceleriYukle();
        }

        private void HuceleriYukle()
        {
            var huceler = _context.PilHucres
                .Where(h => h.LotId == Lot.Id)
                .OrderBy(h => h.SeriNo)
                .ToList();

            dataGridViewHuceler.Rows.Clear();

            if (_sifirPil)
            {
                // Sıfır pil: tek satır
                if (huceler.Any())
                {
                    var ilk = huceler.First();
                    dataGridViewHuceler.Rows.Add(ilk.SeriNo, ilk.Kapasite, ilk.IcDirenc);
                }
                else
                {
                    dataGridViewHuceler.Rows.Add(1, "", "");
                }
                dataGridViewHuceler.AllowUserToAddRows = false;
                dataGridViewHuceler.AllowUserToDeleteRows = false;
            }
            else
            {
                // Çıkma pil: adet kadar satır oluştur, mevcut verileri doldur
                int adet = (int)numericAdet.Value;
                for (int i = 1; i <= adet; i++)
                {
                    dataGridViewHuceler.Rows.Add(i, "", "");
                }

                // Mevcut hücrelerin verilerini doldur
                foreach (var h in huceler)
                {
                    if (h.SeriNo >= 1 && h.SeriNo <= adet)
                    {
                        var row = dataGridViewHuceler.Rows[h.SeriNo - 1];
                        row.Cells[1].Value = h.Kapasite;
                        row.Cells[2].Value = h.IcDirenc;
                    }
                }
                dataGridViewHuceler.AllowUserToAddRows = true;
                dataGridViewHuceler.AllowUserToDeleteRows = true;
            }
        }

        private void chkSifirPil_CheckedChanged(object sender, EventArgs e)
        {
            _sifirPil = chkSifirPil.Checked;
            HuceleriYukle();
        }

        private void numericAdet_ValueChanged(object sender, EventArgs e)
        {
            if (!chkSifirPil.Checked)
            {
                HuceleriYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Lot bilgileri doğrulama
            if (string.IsNullOrWhiteSpace(txtLotAdi.Text))
            {
                MessageBox.Show("Lot adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtBirimMaliyet.Text, out decimal maliyet) || maliyet <= 0)
            {
                MessageBox.Show("Geçerli bir birim maliyet girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericAdet.Value <= 0)
            {
                MessageBox.Show("Adet 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lot bilgilerini güncelle
            Lot.LotAdi = txtLotAdi.Text.Trim();
            Lot.HucreModel = string.IsNullOrWhiteSpace(txtHucreModel.Text) ? null : txtHucreModel.Text.Trim();
            Lot.TedarikciAdi = string.IsNullOrWhiteSpace(txtTedarikciAdi.Text) ? null : txtTedarikciAdi.Text.Trim();
            Lot.TedarikciTelefon = string.IsNullOrWhiteSpace(txtTedarikciTelefon.Text) ? null : txtTedarikciTelefon.Text.Trim();
            Lot.BirimMaliyet = maliyet;
            Lot.Adet = (int)numericAdet.Value;
            Lot.SifirPilMi = chkSifirPil.Checked;
            Lot.Notlar = string.IsNullOrWhiteSpace(txtNotlar.Text) ? null : txtNotlar.Text.Trim();

            if (Lot.Id == 0)
            {
                Lot.GirisTarihi = DateTime.Now;
            }

            // Önce mevcut hücreleri sil
            var mevcutHuceler = _context.PilHucres.Where(h => h.LotId == Lot.Id).ToList();
            _context.PilHucres.RemoveRange(mevcutHuceler);

            if (Lot.SifirPilMi)
            {
                // Sıfır pil: tek satır
                if (dataGridViewHuceler.Rows.Count == 0) return;
                var row = dataGridViewHuceler.Rows[0];
                if (!decimal.TryParse(row.Cells[1].Value?.ToString(), out decimal kapasite) || kapasite <= 0)
                {
                    MessageBox.Show("Geçerli bir kapasite girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(row.Cells[2].Value?.ToString(), out decimal icDirenc) || icDirenc <= 0)
                {
                    MessageBox.Show("Geçerli bir iç direnç girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 1; i <= Lot.Adet; i++)
                {
                    var h = new PilHucresi
                    {
                        LotId = Lot.Id,
                        SeriNo = i,
                        Kapasite = kapasite,
                        IcDirenc = icDirenc,
                        Durum = "Stokta",
                        TestTarihi = DateTime.Now
                    };
                    _context.PilHucres.Add(h);
                }
            }
            else
            {
                // Çıkma pil: her satır bir hücre, boş satırlar atlanır
                int satirSayisi = dataGridViewHuceler.Rows.Count;
                for (int i = 0; i < satirSayisi; i++)
                {
                    var row = dataGridViewHuceler.Rows[i];
                    int seriNo = i + 1;

                    // Kapasite veya iç direnç boşsa atla
                    if (string.IsNullOrWhiteSpace(row.Cells[1].Value?.ToString()) ||
                        string.IsNullOrWhiteSpace(row.Cells[2].Value?.ToString()))
                    {
                        continue;
                    }

                    if (!decimal.TryParse(row.Cells[1].Value.ToString(), out decimal kapasite) || kapasite <= 0)
                    {
                        MessageBox.Show($"Satır {seriNo}: Geçerli bir kapasite girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!decimal.TryParse(row.Cells[2].Value.ToString(), out decimal icDirenc) || icDirenc <= 0)
                    {
                        MessageBox.Show($"Satır {seriNo}: Geçerli bir iç direnç girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var h = new PilHucresi
                    {
                        LotId = Lot.Id,
                        SeriNo = seriNo,
                        Kapasite = kapasite,
                        IcDirenc = icDirenc,
                        Durum = "Stokta",
                        TestTarihi = DateTime.Now
                    };
                    _context.PilHucres.Add(h);
                }
            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}