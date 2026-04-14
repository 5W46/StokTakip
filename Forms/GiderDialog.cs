using System;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class GiderDialog : Form
    {
        public Gider Gider { get; private set; }

        public GiderDialog(Gider? existing = null)
        {
            InitializeComponent();
            if (existing != null)
            {
                Gider = existing;
                dtpTarih.Value = existing.GiderTarihi;
                txtKategori.Text = existing.Kategori;
                txtAciklama.Text = existing.Aciklama;
                txtTutar.Text = existing.Tutar.ToString();
            }
            else
            {
                Gider = new Gider();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategori.Text))
            {
                MessageBox.Show("Kategori boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tutar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Gider.GiderTarihi = dtpTarih.Value;
            Gider.Kategori = txtKategori.Text.Trim();
            Gider.Aciklama = string.IsNullOrWhiteSpace(txtAciklama.Text) ? null : txtAciklama.Text.Trim();
            Gider.Tutar = tutar;

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