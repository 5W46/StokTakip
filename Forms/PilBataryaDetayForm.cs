using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilBataryaDetayForm : Form
    {
        private AppDbContext _context;
        private PilBatarya _batarya;

        public PilBataryaDetayForm(PilBatarya batarya)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _batarya = batarya;
            Text = $"Batarya Detayları - {batarya.BataryaAdi}";

            // Batarya bilgilerini doldur
            txtBataryaAdi.Text = batarya.BataryaAdi;
            txtBataryaAdi.ReadOnly = true;
            txtSeriParalel.Text = $"{batarya.SeriSayisi}S{batarya.ParalelSayisi}P";
            txtToplamKapasite.Text = batarya.ToplamKapasite.ToString("F0");
            txtOrtalamaKapasite.Text = batarya.OrtalamaKapasite.ToString("F0");
            txtToplamIcDirenc.Text = batarya.ToplamIcDirenc.ToString("F1");
            txtOrtalamaIcDirenc.Text = batarya.OrtalamaIcDirenc.ToString("F1");
            txtBMSMarka.Text = batarya.BMSMarka;
            txtBMSModel.Text = batarya.BMSModel;
            txtPilMaliyeti.Text = batarya.PilMaliyeti.ToString("C2");
            txtSarfMalzemeler.Text = batarya.SarfMalzemeler.ToString("C2");
            txtIsçilik.Text = batarya.Isçilik.ToString("C2");
            txtToplamMaliyet.Text = batarya.ToplamMaliyet.ToString("C2");
            txtSatisFiyati.Text = batarya.SatisFiyati.ToString("C2");
            txtKar.Text = batarya.Kar.ToString("C2");
            txtDurum.Text = batarya.Durum;
            txtOlusturmaTarihi.Text = batarya.OlusturmaTarihi.ToString("dd.MM.yyyy HH:mm");
            if (batarya.SatisTarihi.HasValue)
                txtSatisTarihi.Text = batarya.SatisTarihi.Value.ToString("dd.MM.yyyy HH:mm");
            else
                txtSatisTarihi.Text = "-";
            txtNotlar.Text = batarya.Notlar;

            // Kullanılan hücreleri listele
            var hucres = _context.PilBataryaHucres
                .Where(bh => bh.BataryaId == batarya.Id)
                .Include(bh => bh.Hucres)
                .ThenInclude(h => h.Lot)
                .Select(bh => bh.Hucres)
                .OrderBy(h => h.SeriNo)
                .ToList();

            dataGridViewHuceler.Rows.Clear();
            foreach (var h in hucres)
            {
                dataGridViewHuceler.Rows.Add(h.SeriNo, h.Kapasite, h.IcDirenc, h.Lot?.LotAdi);
            }

            // Grupları göster (opsiyonel: seri grupları)
            if (batarya.SeriSayisi > 0 && batarya.ParalelSayisi > 0)
            {
                int grupAdet = batarya.SeriSayisi;
                int paralelAdet = batarya.ParalelSayisi;
                var gruplar = hucres.Select((h, idx) => new { h, idx })
                                    .GroupBy(x => x.idx / paralelAdet)
                                    .Select(g => g.Select(x => x.h).ToList())
                                    .ToList();

                dataGridViewGruplar.Rows.Clear();
                for (int i = 0; i < gruplar.Count; i++)
                {
                    var grup = gruplar[i];
                    string seriNoList = string.Join(", ", grup.Select(h => h.SeriNo));
                    double ortalamaKapasite = grup.Average(h => (double)h.Kapasite);
                    double ortalamaIcDirenc = grup.Average(h => (double)h.IcDirenc);
                    dataGridViewGruplar.Rows.Add(i + 1, seriNoList, Math.Round(ortalamaKapasite), Math.Round(ortalamaIcDirenc, 1));
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PilBataryaDetayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}