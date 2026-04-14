using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilGrupDetayForm : Form
    {
        public PilGrupDetayForm(List<PilHucresi> grup)
        {
            InitializeComponent();
            Text = $"Grup Detayları - {grup.Count} hücre";
            dataGridViewDetay.Rows.Clear();
            foreach (var h in grup.OrderBy(h => h.SeriNo))
            {
                dataGridViewDetay.Rows.Add(h.SeriNo, h.Kapasite, h.IcDirenc);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}