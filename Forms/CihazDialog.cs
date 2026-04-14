using System;
using System.Linq;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class CihazDialog : Form
    {
        private AppDbContext _context;
        public Cihaz Cihaz { get; private set; }

        public CihazDialog(Cihaz? existing = null)
        {
            InitializeComponent();
            _context = new AppDbContext();
            if (existing != null)
            {
                Cihaz = existing;
                txtMarkaModel.Text = existing.MarkaModel;
                txtSeriNo.Text = existing.SeriNo;
                cmbDurum.Text = existing.Durum;
                txtAlisMaliyeti.Text = existing.AlisMaliyeti.ToString();
                txtSatisFiyati.Text = existing.SatisFiyati.ToString();
                txtNotlar.Text = existing.Notlar;
                txtAlinanKisiAdSoyad.Text = existing.AlinanKisiAdSoyad;
                txtAlinanKisiTelefon.Text = existing.AlinanKisiTelefon;
            }
            else
            {
                Cihaz = new Cihaz();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarkaModel.Text))
            {
                MessageBox.Show("Marka/Model boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seriNo = txtSeriNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(seriNo))
            {
                string baseNo = txtMarkaModel.Text.Trim().Replace(" ", "_");
                int sayac = 1;
                while (true)
                {
                    string yeniSeriNo = $"{baseNo}_{sayac}";
                    var mevcut = _context.Cihazlar.FirstOrDefault(c => c.SeriNo == yeniSeriNo);
                    if (mevcut == null)
                    {
                        seriNo = yeniSeriNo;
                        break;
                    }
                    sayac++;
                }
            }
            else
            {
                var mevcut = _context.Cihazlar.FirstOrDefault(c => c.SeriNo == seriNo && c.Id != Cihaz.Id);
                if (mevcut != null)
                {
                    MessageBox.Show("Bu seri numarası zaten kullanılıyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            Cihaz.MarkaModel = txtMarkaModel.Text.Trim();
            Cihaz.SeriNo = seriNo;
            Cihaz.Durum = cmbDurum.Text;
            Cihaz.AlisMaliyeti = decimal.TryParse(txtAlisMaliyeti.Text, out decimal alis) ? alis : 0;
            Cihaz.SatisFiyati = decimal.TryParse(txtSatisFiyati.Text, out decimal satis) ? satis : 0;
            Cihaz.Notlar = string.IsNullOrWhiteSpace(txtNotlar.Text) ? null : txtNotlar.Text.Trim();
            Cihaz.AlinanKisiAdSoyad = string.IsNullOrWhiteSpace(txtAlinanKisiAdSoyad.Text) ? null : txtAlinanKisiAdSoyad.Text.Trim();
            Cihaz.AlinanKisiTelefon = string.IsNullOrWhiteSpace(txtAlinanKisiTelefon.Text) ? null : txtAlinanKisiTelefon.Text.Trim();

            if (Cihaz.Id == 0)
                Cihaz.CreatedAt = DateTime.Now;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosing(e);
        }
    }
}