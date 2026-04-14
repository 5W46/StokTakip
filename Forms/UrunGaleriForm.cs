using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;
using StokTakip.Helpers;

namespace StokTakip.Forms
{
    public partial class UrunGaleriForm : Form
    {
        private AppDbContext _context;
        private List<Urun> _urunler;
        public Urun? SecilenUrun { get; private set; }

        public UrunGaleriForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            UrunleriYukle("");
        }

        private void UrunleriYukle(string filter)
        {
            _urunler = _context.Urunler
                .Where(u => string.IsNullOrEmpty(filter) ||
                            u.UrunAdi.ToLower().Contains(filter.ToLower()) ||
                            (u.Barkod != null && u.Barkod.ToLower().Contains(filter.ToLower())))
                .OrderBy(u => u.UrunAdi)
                .ToList();

            flowPanel.Controls.Clear();
            foreach (var urun in _urunler)
            {
                // Tüm panel tıklanabilir olsun
                var panel = new Panel
                {
                    Width = 150,
                    Height = 180,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Tag = urun,
                    Cursor = Cursors.Hand
                };
                panel.Click += (s, e) => UrunSec(urun);

                // Resim
                PictureBox pb = new PictureBox
                {
                    Width = 130,
                    Height = 100,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10, 10)
                };
                if (!string.IsNullOrEmpty(urun.FotografYolu))
                {
                    var img = FileHelper.GetProductThumbnail(urun.FotografYolu);
                    if (img != null) pb.Image = img;
                }
                pb.Click += (s, e) => UrunSec(urun);
                panel.Controls.Add(pb);

                // Ürün adı
                Label lblAd = new Label
                {
                    Text = urun.UrunAdi,
                    AutoSize = false,
                    Width = 130,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(10, 120),
                    Font = new Font("Segoe UI", 8, FontStyle.Bold)
                };
                lblAd.Click += (s, e) => UrunSec(urun);
                panel.Controls.Add(lblAd);

                // Fiyat
                Label lblFiyat = new Label
                {
                    Text = urun.SatisFiyati.ToString("C2"),
                    AutoSize = false,
                    Width = 130,
                    Height = 20,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(10, 150),
                    ForeColor = Color.Green
                };
                lblFiyat.Click += (s, e) => UrunSec(urun);
                panel.Controls.Add(lblFiyat);

                flowPanel.Controls.Add(panel);
            }
        }

        private void UrunSec(Urun urun)
        {
            SecilenUrun = urun;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            UrunleriYukle(txtAra.Text.Trim());
        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra_Click(sender, e);
                e.SuppressKeyPress = true;
            }
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