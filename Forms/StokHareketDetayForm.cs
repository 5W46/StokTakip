using System;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class StokHareketDetayForm : Form
    {
        public StokHareketDetayForm(StokHareket hareket)
        {
            InitializeComponent();
            Text = $"Stok Hareketi #{hareket.Id}";

            lblUrun.Text = hareket.Urun?.UrunAdi ?? "?";
            lblTip.Text = hareket.HareketTipi;
            lblMiktar.Text = hareket.Miktar.ToString();
            lblTarih.Text = hareket.Tarih.ToString("dd.MM.yyyy HH:mm");
            lblAciklama.Text = hareket.Aciklama ?? "-";

            if (hareket.HareketTipi == "Giriş")
            {
                lblTedarikciAdi.Text = hareket.TedarikciAdi ?? "-";
                lblTedarikciTelefon.Text = hareket.TedarikciTelefon ?? "-";
                panelTedarikci.Visible = true;
                panelMusteri.Visible = false;
                panelCihaz.Visible = false;
            }
            else if (hareket.HareketTipi == "Çıkış")
            {
                if (hareket.CihazId.HasValue)
                {
                    using (var db = new AppDbContext())
                    {
                        var cihaz = db.Cihazlar.Find(hareket.CihazId.Value);
                        lblCihaz.Text = cihaz?.SeriNo ?? hareket.CihazId.ToString();
                    }
                    panelCihaz.Visible = true;
                    panelMusteri.Visible = false;
                    panelTedarikci.Visible = false;
                }
                else
                {
                    panelMusteri.Visible = true;
                    panelTedarikci.Visible = false;
                    panelCihaz.Visible = false;
                    lblMusteriAdi.Text = hareket.MusteriAdi ?? "-";
                    lblMusteriTelefon.Text = hareket.MusteriTelefon ?? "-";
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}