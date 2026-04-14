using System;
using System.Windows.Forms;
using StokTakip.Models;
using StokTakip.Helpers;

namespace StokTakip.Forms
{
    public partial class UrunDialog : Form
    {
        public Urun Urun { get; private set; }
        private string _tempImagePath = null;

        public UrunDialog(Urun? existing = null)
        {
            InitializeComponent();
            if (existing != null)
            {
                Urun = existing;
                txtBarkod.Text = existing.Barkod ?? "";
                txtUrunAdi.Text = existing.UrunAdi;
                txtAlisFiyati.Text = existing.AlisFiyati.ToString();
                txtSatisFiyati.Text = existing.SatisFiyati.ToString();
                txtStokMiktari.Text = existing.StokMiktari.ToString();
                txtMinStok.Text = existing.MinStok.ToString();
                txtAlinanYer.Text = existing.AlinanYer ?? "";
                txtAlinanNumara.Text = existing.AlinanNumara ?? "";
                txtAciklama.Text = existing.Aciklama ?? "";
                if (!string.IsNullOrEmpty(existing.FotografYolu))
                {
                    var img = FileHelper.GetProductThumbnail(existing.FotografYolu);
                    if (img != null)
                        pictureBox.Image = img;
                }
            }
            else
            {
                Urun = new Urun();
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _tempImagePath = ofd.FileName;
                    pictureBox.Image = System.Drawing.Image.FromFile(_tempImagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnResimTemizle_Click(object sender, EventArgs e)
        {
            _tempImagePath = null;
            pictureBox.Image = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAlisFiyati.Text, out decimal alis) ||
                !decimal.TryParse(txtSatisFiyati.Text, out decimal satis) ||
                !int.TryParse(txtStokMiktari.Text, out int stok) ||
                !int.TryParse(txtMinStok.Text, out int minStok))
            {
                MessageBox.Show("Sayısal alanları doğru giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Urun.Barkod = string.IsNullOrWhiteSpace(txtBarkod.Text) ? null : txtBarkod.Text.Trim();
            Urun.UrunAdi = txtUrunAdi.Text.Trim();
            Urun.AlisFiyati = alis;
            Urun.SatisFiyati = satis;
            Urun.StokMiktari = stok;
            Urun.MinStok = minStok;
            Urun.AlinanYer = string.IsNullOrWhiteSpace(txtAlinanYer.Text) ? null : txtAlinanYer.Text.Trim();
            Urun.AlinanNumara = string.IsNullOrWhiteSpace(txtAlinanNumara.Text) ? null : txtAlinanNumara.Text.Trim();
            Urun.Aciklama = string.IsNullOrWhiteSpace(txtAciklama.Text) ? null : txtAciklama.Text.Trim();

            // Resim işleme
            if (!string.IsNullOrEmpty(_tempImagePath))
            {
                // Önce eski resmi sil (varsa)
                if (!string.IsNullOrEmpty(Urun.FotografYolu))
                {
                    // Eğer pictureBox'ta hâlâ eski resim varsa, onu temizle
                    pictureBox.Image?.Dispose();
                    pictureBox.Image = null;
                    FileHelper.DeleteProductImage(Urun.FotografYolu);
                }
                // Yeni resmi kaydet
                string fileName = FileHelper.SaveProductImage(_tempImagePath, Urun.Id == 0 ? 0 : Urun.Id);
                Urun.FotografYolu = fileName;
            }
            else if (Urun.Id != 0 && string.IsNullOrEmpty(_tempImagePath) && Urun.FotografYolu != null)
            {
                // Resim temizlendi, eskiyi sil
                pictureBox.Image?.Dispose();
                pictureBox.Image = null;
                FileHelper.DeleteProductImage(Urun.FotografYolu);
                Urun.FotografYolu = null;
            }

            if (Urun.Id == 0)
                Urun.CreatedAt = DateTime.Now;
            Urun.UpdatedAt = DateTime.Now;

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