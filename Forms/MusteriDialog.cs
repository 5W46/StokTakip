using System;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class MusteriDialog : Form
    {
        public Musteri Musteri { get; private set; }

        public MusteriDialog(Musteri? existing = null)
        {
            InitializeComponent();
            if (existing != null)
            {
                Musteri = existing;
                txtAd.Text = existing.Ad ?? "";
                txtSoyad.Text = existing.Soyad ?? "";
                txtTelefon.Text = existing.Telefon ?? "";
                txtEmail.Text = existing.Email ?? "";
                txtAdres.Text = existing.Adres ?? "";
            }
            else
            {
                Musteri = new Musteri();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) && string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad veya soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Musteri.Ad = txtAd.Text.Trim();
            Musteri.Soyad = txtSoyad.Text.Trim();
            Musteri.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            Musteri.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
            Musteri.Adres = string.IsNullOrWhiteSpace(txtAdres.Text) ? null : txtAdres.Text.Trim();

            if (Musteri.Id == 0)
                Musteri.CreatedAt = DateTime.Now;

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