using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilBataryaOlusturForm : Form
    {
        private AppDbContext _context;
        private PilLot _lot;
        private List<PilHucresi> _secilenHucres;
        private int _seriSayisi;
        private int _paralelSayisi;

        public PilBataryaOlusturForm(PilLot lot, List<PilHucresi> secilenHucres, int seriSayisi, int paralelSayisi)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _lot = lot;
            _secilenHucres = secilenHucres;
            _seriSayisi = seriSayisi;
            _paralelSayisi = paralelSayisi;

            // Hesaplanan değerler
            decimal ortalamaKapasite = _secilenHucres.Average(h => h.Kapasite);
            decimal toplamKapasite = ortalamaKapasite * _paralelSayisi;
            decimal ortalamaIcDirenc = _secilenHucres.Average(h => h.IcDirenc);
            decimal toplamIcDirenc = (_seriSayisi * ortalamaIcDirenc) / _paralelSayisi;

            lblHesaplanan.Text = $"Ort. Kapasite: {ortalamaKapasite:F0} mAh | Toplam Kapasite: {toplamKapasite:F0} mAh\n" +
                                 $"Ort. İç Direnç: {ortalamaIcDirenc:F1} mΩ | Toplam İç Direnç: {toplamIcDirenc:F1} mΩ";

            txtBataryaAdi.Text = $"{_lot.LotAdi} {_seriSayisi}S{_paralelSayisi}P";
            numericPilMaliyeti.Value = _secilenHucres.Sum(h => _lot.BirimMaliyet);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBataryaAdi.Text))
            {
                MessageBox.Show("Batarya adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Batarya nesnesi oluştur
            var batarya = new PilBatarya
            {
                BataryaAdi = txtBataryaAdi.Text.Trim(),
                SeriSayisi = _seriSayisi,
                ParalelSayisi = _paralelSayisi,
                ToplamKapasite = _secilenHucres.Average(h => h.Kapasite) * _paralelSayisi,
                OrtalamaKapasite = _secilenHucres.Average(h => h.Kapasite),
                ToplamIcDirenc = (_seriSayisi * _secilenHucres.Average(h => h.IcDirenc)) / _paralelSayisi,
                OrtalamaIcDirenc = _secilenHucres.Average(h => h.IcDirenc),
                BMSMarka = string.IsNullOrWhiteSpace(txtBMSMarka.Text) ? null : txtBMSMarka.Text.Trim(),
                BMSModel = string.IsNullOrWhiteSpace(txtBMSModel.Text) ? null : txtBMSModel.Text.Trim(),
                PilMaliyeti = (decimal)numericPilMaliyeti.Value,
                SarfMalzemeler = (decimal)numericSarf.Value,
                Isçilik = (decimal)numericIsçilik.Value,
                SatisFiyati = (decimal)numericSatisFiyati.Value,
                Durum = "Üretim Aşamasında",
                OlusturmaTarihi = DateTime.Now,
                Notlar = string.IsNullOrWhiteSpace(txtNotlar.Text) ? null : txtNotlar.Text.Trim()
            };

            _context.PilBataryalar.Add(batarya);
            _context.SaveChanges(); // Batarya ID'si oluşur

            // Hücreleri bataryaya bağla ve durumlarını "Bataryada" yap
            foreach (var h in _secilenHucres)
            {
                // Hücreyi veritabanından yeniden al (attached ve takip edilir)
                var hucres = _context.PilHucres.Find(h.Id);
                if (hucres != null)
                {
                    hucres.Durum = "Bataryada";
                }

                var baglanti = new PilBataryaHucresi
                {
                    BataryaId = batarya.Id,
                    HucresId = h.Id
                };
                _context.PilBataryaHucres.Add(baglanti);
            }
            _context.SaveChanges();

            MessageBox.Show("Batarya başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}