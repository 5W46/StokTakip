using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Stok değişikliklerini dinle
            StokForm.StokGuncellendi += StokForm_StokGuncellendi;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Helpers.DatabaseHelper.EnsureDatabaseCreated();
            StokUyarilariYukle();
        }

        private void StokUyarilariYukle()
        {
            using (var context = new AppDbContext())
            {
                var kritikUrunler = context.Urunler
                    .Where(u => u.StokMiktari <= u.MinStok)
                    .OrderBy(u => u.UrunAdi)
                    .ToList();

                listStokUyarilari.Items.Clear();
                foreach (var urun in kritikUrunler)
                {
                    listStokUyarilari.Items.Add($"{urun.UrunAdi} - Stok: {urun.StokMiktari} (Min: {urun.MinStok})");
                }
            }
        }

        private void StokForm_StokGuncellendi(object? sender, EventArgs e)
        {
            // UI thread'te güvenli yenileme
            if (InvokeRequired)
                Invoke(new Action(StokUyarilariYukle));
            else
                StokUyarilariYukle();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            var form = new StokForm();
            form.ShowDialog();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            var form = new SatisForm();
            form.ShowDialog();
        }

        private void btnScooter_Click(object sender, EventArgs e)
        {
            var form = new CihazForm();
            form.ShowDialog();
        }

        private void btnBatarya_Click(object sender, EventArgs e)
        {
            var form = new PilLotListForm();
            form.ShowDialog();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            var form = new GelirGiderForm();
            form.ShowDialog();
        }

        private void btnMusteriYonetim_Click(object sender, EventArgs e)
        {
            var form = new MusteriYonetimForm();
            form.ShowDialog();
        }
    }
}