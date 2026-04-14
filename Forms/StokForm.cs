using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;
using StokTakip.Helpers;

namespace StokTakip.Forms
{
    public partial class StokForm : Form
    {
        private AppDbContext _context;

        // Stok değişiklikleri için statik olay
        public static event EventHandler? StokGuncellendi;

        public StokForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            SiparisDetayForm.OrderUpdated += SiparisDetayForm_OrderUpdated;
            dataGridViewHistory.CellDoubleClick += DataGridViewHistory_CellDoubleClick;
        }

        private void DataGridViewHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int hareketId = Convert.ToInt32(dataGridViewHistory.Rows[e.RowIndex].Cells[0].Value);
            var hareket = _context.StokHareketleri
                .Include(h => h.Urun)
                .FirstOrDefault(h => h.Id == hareketId);
            if (hareket != null)
            {
                using (var detayForm = new StokHareketDetayForm(hareket))
                {
                    detayForm.ShowDialog();
                }
            }
        }

        private void SiparisDetayForm_OrderUpdated(object? sender, EventArgs e)
        {
            if (InvokeRequired)
                Invoke(new Action(LoadProducts));
            else
                LoadProducts();
            StokGuncellendi?.Invoke(this, EventArgs.Empty);
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (var freshContext = new AppDbContext())
            {
                var products = freshContext.Urunler
                    .AsNoTracking()
                    .OrderBy(p => p.UrunAdi)
                    .ToList();

                dataGridViewProducts.Rows.Clear();
                foreach (var p in products)
                {
                    int rowIndex = dataGridViewProducts.Rows.Add();
                    dataGridViewProducts.Rows[rowIndex].Cells[0].Value = p.Id;
                    dataGridViewProducts.Rows[rowIndex].Cells[1].Value = p.Barkod ?? "";
                    dataGridViewProducts.Rows[rowIndex].Cells[2].Value = p.UrunAdi;
                    dataGridViewProducts.Rows[rowIndex].Cells[3].Value = p.StokMiktari;
                    dataGridViewProducts.Rows[rowIndex].Cells[4].Value = p.MinStok;
                    dataGridViewProducts.Rows[rowIndex].Cells[5].Value = p.AlisFiyati;
                    dataGridViewProducts.Rows[rowIndex].Cells[6].Value = p.SatisFiyati;
                    dataGridViewProducts.Rows[rowIndex].Cells[7].Value = p.SatisFiyati - p.AlisFiyati;

                    // Resim yükle
                    if (!string.IsNullOrEmpty(p.FotografYolu))
                    {
                        var img = FileHelper.GetProductThumbnail(p.FotografYolu);
                        if (img != null)
                            dataGridViewProducts.Rows[rowIndex].Cells[8].Value = img;
                    }

                    if (p.StokMiktari <= p.MinStok)
                        dataGridViewProducts.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                }

                if (dataGridViewProducts.Rows.Count > 0)
                {
                    dataGridViewProducts.ClearSelection();
                    dataGridViewProducts.Rows[0].Selected = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new UrunDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(dialog.Urun.Barkod))
                    {
                        string baseBarkod = NormalizeBarkod(dialog.Urun.UrunAdi);
                        int sayac = 1;
                        while (true)
                        {
                            string yeniBarkod = $"{baseBarkod}{sayac:D3}";
                            var mevcut = _context.Urunler.FirstOrDefault(u => u.Barkod == yeniBarkod);
                            if (mevcut == null)
                            {
                                dialog.Urun.Barkod = yeniBarkod;
                                break;
                            }
                            sayac++;
                        }
                    }
                    _context.Urunler.Add(dialog.Urun);
                    _context.SaveChanges();
                    LoadProducts();
                    StokGuncellendi?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private string NormalizeBarkod(string text)
        {
            if (string.IsNullOrEmpty(text)) return "URUN";
            string normalized = text.ToUpper()
                .Replace('I', 'I')
                .Replace('İ', 'I')
                .Replace('Ö', 'O')
                .Replace('Ü', 'U')
                .Replace('Ş', 'S')
                .Replace('Ğ', 'G')
                .Replace('Ç', 'C')
                .Replace(' ', '_');
            if (normalized.Length > 8) normalized = normalized.Substring(0, 8);
            return normalized;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
            var product = _context.Urunler.Find(id);
            if (product == null) return;

            using (var dialog = new UrunDialog(product))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(product).CurrentValues.SetValues(dialog.Urun);
                    _context.SaveChanges();
                    LoadProducts();
                    StokGuncellendi?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            PerformStockTransaction("Giriş");
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            PerformStockTransaction("Çıkış");
        }

        private void PerformStockTransaction(string transactionType)
        {
            if (dataGridViewProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
            var product = _context.Urunler.Find(id);
            if (product == null) return;

            if (transactionType == "Giriş")
            {
                using (var dialog = new StokGirisDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        int miktar = dialog.Miktar;
                        string aciklama = dialog.Aciklama;
                        string tedarikciAdi = dialog.TedarikciAdi;
                        string tedarikciTelefon = dialog.TedarikciTelefon;

                        int oncekiStok = product.StokMiktari;
                        product.StokMiktari += miktar;

                        var hareket = new StokHareket
                        {
                            UrunId = product.Id,
                            HareketTipi = "Giriş",
                            Miktar = miktar,
                            OncekiStok = oncekiStok,
                            SonrakiStok = product.StokMiktari,
                            Aciklama = string.IsNullOrWhiteSpace(aciklama) ? null : aciklama,
                            Tarih = DateTime.Now,
                            TedarikciAdi = string.IsNullOrWhiteSpace(tedarikciAdi) ? null : tedarikciAdi,
                            TedarikciTelefon = string.IsNullOrWhiteSpace(tedarikciTelefon) ? null : tedarikciTelefon
                        };
                        _context.StokHareketleri.Add(hareket);
                        _context.SaveChanges();
                        LoadProducts();
                        LoadHistory(product.Id);
                        StokGuncellendi?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            else // Çıkış
            {
                string miktarStr = ShowInputDialog("Çıkış miktarını girin:", "Stok Çıkış");
                if (!int.TryParse(miktarStr, out int miktar) || miktar <= 0) return;

                if (product.StokMiktari < miktar)
                {
                    MessageBox.Show("Yeterli stok yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string aciklama = ShowInputDialog("Açıklama (opsiyonel):", "Stok Çıkış");

                int oncekiStok = product.StokMiktari;
                product.StokMiktari -= miktar;

                var hareket = new StokHareket
                {
                    UrunId = product.Id,
                    HareketTipi = "Çıkış",
                    Miktar = miktar,
                    OncekiStok = oncekiStok,
                    SonrakiStok = product.StokMiktari,
                    Aciklama = string.IsNullOrWhiteSpace(aciklama) ? null : aciklama,
                    Tarih = DateTime.Now
                };
                _context.StokHareketleri.Add(hareket);
                _context.SaveChanges();
                LoadProducts();
                LoadHistory(product.Id);
                StokGuncellendi?.Invoke(this, EventArgs.Empty);
            }
        }

        private string ShowInputDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 350 };
            Button confirmation = new Button() { Text = "OK", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();
            using (var freshContext = new AppDbContext())
            {
                var query = freshContext.Urunler.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(p => p.UrunAdi.ToLower().Contains(search) ||
                                             (p.Barkod != null && p.Barkod.ToLower().Contains(search)));
                }
                var products = query.OrderBy(p => p.UrunAdi).ToList();

                dataGridViewProducts.Rows.Clear();
                foreach (var p in products)
                {
                    int rowIndex = dataGridViewProducts.Rows.Add();
                    dataGridViewProducts.Rows[rowIndex].Cells[0].Value = p.Id;
                    dataGridViewProducts.Rows[rowIndex].Cells[1].Value = p.Barkod ?? "";
                    dataGridViewProducts.Rows[rowIndex].Cells[2].Value = p.UrunAdi;
                    dataGridViewProducts.Rows[rowIndex].Cells[3].Value = p.StokMiktari;
                    dataGridViewProducts.Rows[rowIndex].Cells[4].Value = p.MinStok;
                    dataGridViewProducts.Rows[rowIndex].Cells[5].Value = p.AlisFiyati;
                    dataGridViewProducts.Rows[rowIndex].Cells[6].Value = p.SatisFiyati;
                    dataGridViewProducts.Rows[rowIndex].Cells[7].Value = p.SatisFiyati - p.AlisFiyati;

                    if (!string.IsNullOrEmpty(p.FotografYolu))
                    {
                        var img = FileHelper.GetProductThumbnail(p.FotografYolu);
                        if (img != null)
                            dataGridViewProducts.Rows[rowIndex].Cells[8].Value = img;
                    }

                    if (p.StokMiktari <= p.MinStok)
                        dataGridViewProducts.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null && dataGridViewProducts.CurrentRow.Cells[0].Value != null)
            {
                int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
                LoadHistory(id);
            }
        }

        private void LoadHistory(int productId)
        {
            var history = _context.StokHareketleri
                .Where(h => h.UrunId == productId)
                .OrderByDescending(h => h.Tarih)
                .ToList();

            dataGridViewHistory.Rows.Clear();
            foreach (var h in history)
            {
                string aciklama = h.Aciklama ?? "";

                if (h.HareketTipi == "Giriş" && !string.IsNullOrWhiteSpace(h.TedarikciAdi))
                {
                    if (!string.IsNullOrWhiteSpace(aciklama))
                        aciklama = $"Tedarikçi: {h.TedarikciAdi} - {aciklama}";
                    else
                        aciklama = $"Tedarikçi: {h.TedarikciAdi}";
                }

                dataGridViewHistory.Rows.Add(
                    h.Id,
                    h.Tarih.ToString("dd.MM.yyyy HH:mm"),
                    h.HareketTipi,
                    h.Miktar,
                    aciklama
                );
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void StokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SiparisDetayForm.OrderUpdated -= SiparisDetayForm_OrderUpdated;
            _context.Dispose();
        }
    }
}