using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilLotDetayForm : Form
    {
        private AppDbContext _context;
        private PilLot _lot;
        private bool _sifirPil;

        public PilLotDetayForm(PilLot lot)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _lot = lot;
            _sifirPil = lot.SifirPilMi;
            Text = $"Lot Detayları - {lot.LotAdi}";

            // Lot bilgilerini doldur (salt okunur)
            txtLotAdi.Text = lot.LotAdi;
            txtLotAdi.ReadOnly = true;
            txtHucreModel.Text = lot.HucreModel;
            txtHucreModel.ReadOnly = true;
            txtTedarikciAdi.Text = lot.TedarikciAdi;
            txtTedarikciAdi.ReadOnly = true;
            txtTedarikciTelefon.Text = lot.TedarikciTelefon;
            txtTedarikciTelefon.ReadOnly = true;
            txtBirimMaliyet.Text = lot.BirimMaliyet.ToString();
            txtBirimMaliyet.ReadOnly = true;
            numericAdet.Value = lot.Adet;
            numericAdet.Enabled = false;
            chkSifirPil.Checked = lot.SifirPilMi;
            chkSifirPil.Enabled = false;
            txtNotlar.Text = lot.Notlar;
            txtNotlar.ReadOnly = true;

            HuceleriYukle();
        }

        private void HuceleriYukle()
        {
            // Sadece Durum = "Stokta" olan hücreleri al
            var huceler = _context.PilHucres
                .Where(h => h.LotId == _lot.Id && h.Durum == "Stokta")
                .OrderBy(h => h.SeriNo)
                .ToList();

            dataGridViewHuceler.Rows.Clear();

            if (_sifirPil && huceler.Any())
            {
                var ilk = huceler.First();
                dataGridViewHuceler.Rows.Add(ilk.SeriNo, ilk.Kapasite, ilk.IcDirenc);
                dataGridViewHuceler.AllowUserToAddRows = false;
                dataGridViewHuceler.AllowUserToDeleteRows = false;
                dataGridViewHuceler.ReadOnly = true;
                lblUyari.Visible = true;
                lblUyari.Text = "Sıfır pil lotu: Bu değer tüm hücreler için geçerlidir.";
            }
            else if (!_sifirPil)
            {
                foreach (var h in huceler)
                {
                    dataGridViewHuceler.Rows.Add(h.SeriNo, h.Kapasite, h.IcDirenc);
                }
                dataGridViewHuceler.AllowUserToAddRows = false;
                dataGridViewHuceler.AllowUserToDeleteRows = false;
                dataGridViewHuceler.ReadOnly = true;
                lblUyari.Visible = false;
            }
            else
            {
                if (_sifirPil)
                {
                    dataGridViewHuceler.Rows.Add(1, "", "");
                    dataGridViewHuceler.ReadOnly = true;
                    lblUyari.Visible = true;
                }
                else
                {
                    for (int i = 1; i <= _lot.Adet; i++)
                    {
                        dataGridViewHuceler.Rows.Add(i, "", "");
                    }
                    dataGridViewHuceler.ReadOnly = true;
                    lblUyari.Visible = false;
                }
                dataGridViewHuceler.AllowUserToAddRows = false;
                dataGridViewHuceler.AllowUserToDeleteRows = false;
            }

            int kalanAdet = huceler.Count;
            lblKalanAdet.Text = $"Kalan Hücre Adedi: {kalanAdet} / {_lot.Adet}";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PilLotDetayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}