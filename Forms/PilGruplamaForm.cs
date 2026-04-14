using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilGruplamaForm : Form
    {
        private AppDbContext _context;
        private PilLot _lot;
        private List<PilHucresi> _kullanilabilirHuceler;
        private int _seriSayisi;
        private int _paralelSayisi;
        private double _tolerans;          // 0.05, 0.10, 0.15
        private int _agirlik;              // 0..100
        private List<List<PilHucresi>> _gruplar;

        public PilGruplamaForm(PilLot lot)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _lot = lot;
            Text = $"Batarya Gruplama - {lot.LotAdi}";
            cmbTolerans.SelectedIndex = 1; // Normal %10
            trackBarOncelik.Value = 50;
            lblOncelik.Text = "Kapasite / İç Direnç (50/50)";
            dataGridViewSonuc.CellDoubleClick += DataGridViewSonuc_CellDoubleClick;
        }

        private void btnGrupla_Click(object sender, EventArgs e)
        {
            // Parametreleri al
            if (!int.TryParse(txtSeriSayisi.Text, out _seriSayisi) || _seriSayisi <= 0)
            {
                MessageBox.Show("Geçerli bir seri sayısı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtParalelSayisi.Text, out _paralelSayisi) || _paralelSayisi <= 0)
            {
                MessageBox.Show("Geçerli bir paralel sayısı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _agirlik = trackBarOncelik.Value;

            switch (cmbTolerans.SelectedIndex)
            {
                case 0: _tolerans = 0.05; break;
                case 1: _tolerans = 0.10; break;
                case 2: _tolerans = 0.15; break;
                default: _tolerans = 0.10; break;
            }

            // Kullanılabilir hücreleri al (Durum = "Stokta")
            _kullanilabilirHuceler = _context.PilHucres
                .Where(h => h.LotId == _lot.Id && h.Durum == "Stokta")
                .OrderBy(h => h.SeriNo)
                .ToList();

            int ihtiyac = _seriSayisi * _paralelSayisi;
            if (_kullanilabilirHuceler.Count < ihtiyac)
            {
                MessageBox.Show($"Yeterli hücre yok! İhtiyaç: {ihtiyac}, Mevcut: {_kullanilabilirHuceler.Count}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Hücreleri iç dirençlerine göre sırala
            var siraliHuceler = _kullanilabilirHuceler.OrderBy(h => h.IcDirenc).ToList();

            // 2. En iyi pencereyi bul (iç direnç toleransına uyan, kapasite ağırlıklı)
            List<PilHucresi> enIyiPencere = null;
            double enIyiSkor = -1;
            int enUygunAdet = 0;

            for (int baslangic = 0; baslangic <= siraliHuceler.Count - ihtiyac; baslangic++)
            {
                var pencere = siraliHuceler.Skip(baslangic).Take(ihtiyac).ToList();
                double minIr = pencere.Min(h => (double)h.IcDirenc);
                double maxIr = pencere.Max(h => (double)h.IcDirenc);
                double ortalamaIr = pencere.Average(h => (double)h.IcDirenc);
                double farkOrani = (maxIr - minIr) / ortalamaIr;

                if (farkOrani <= _tolerans)
                {
                    // Uygun pencere: kapasite ağırlığına göre skor hesapla
                    double ortalamaKapasite = pencere.Average(h => (double)h.Kapasite);
                    double skor = ortalamaKapasite * (100 - _agirlik) + (1.0 / ortalamaIr) * _agirlik;
                    if (skor > enIyiSkor)
                    {
                        enIyiSkor = skor;
                        enIyiPencere = pencere;
                    }
                }
                else
                {
                    // Tolerans dışındaki pencerelerde kaç adet hücre tolerans içinde?
                    int uygunAdet = pencere.Count(h => Math.Abs((double)h.IcDirenc - ortalamaIr) <= ortalamaIr * _tolerans);
                    if (uygunAdet > enUygunAdet) enUygunAdet = uygunAdet;
                }
            }

            if (enIyiPencere == null)
            {
                MessageBox.Show($"Hiçbir pencere iç direnç toleransını sağlamıyor.\nTolerans içinde en fazla {enUygunAdet} hücre var.\nFarklı tolerans deneyin veya manuel seçim yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Seçilen penceredeki hücreleri gruplara dağıt (yılan usulü)
            _gruplar = new List<List<PilHucresi>>();
            for (int i = 0; i < _seriSayisi; i++)
                _gruplar.Add(new List<PilHucresi>());

            for (int i = 0; i < enIyiPencere.Count; i++)
            {
                int grupIndex = i % _seriSayisi;
                if ((i / _seriSayisi) % 2 == 1)
                    grupIndex = _seriSayisi - 1 - grupIndex;
                _gruplar[grupIndex].Add(enIyiPencere[i]);
            }

            // 4. Sonuçları DataGridView'de göster
            dataGridViewSonuc.Rows.Clear();
            for (int i = 0; i < _gruplar.Count; i++)
            {
                var grup = _gruplar[i];
                string seriNoList = string.Join(", ", grup.Select(h => h.SeriNo).OrderBy(s => s));
                double ortalamaKapasite = grup.Average(h => (double)h.Kapasite);
                double ortalamaIcDirenc = grup.Average(h => (double)h.IcDirenc);
                dataGridViewSonuc.Rows.Add(i + 1, seriNoList, Math.Round(ortalamaKapasite), Math.Round(ortalamaIcDirenc, 1));
            }

            btnOlustur.Enabled = true;
        }

        private void DataGridViewSonuc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _gruplar == null || e.RowIndex >= _gruplar.Count) return;
            var grup = _gruplar[e.RowIndex];
            var detayForm = new PilGrupDetayForm(grup);
            detayForm.ShowDialog();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (_gruplar == null) return;
            var secilenHucres = _gruplar.SelectMany(g => g).ToList();

            using (var dialog = new PilBataryaOlusturForm(_lot, secilenHucres, _seriSayisi, _paralelSayisi))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void trackBarOncelik_Scroll(object sender, EventArgs e)
        {
            _agirlik = trackBarOncelik.Value;
            lblOncelik.Text = $"Kapasite / İç Direnç ({100 - _agirlik}/{_agirlik})";
        }
    }
}