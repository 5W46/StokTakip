using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class PilHucresiGirisForm : Form
    {
        private AppDbContext _context;
        private PilLot _lot;
        private bool _sifirPil;

        public PilHucresiGirisForm(PilLot lot)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _lot = lot;
            _sifirPil = lot.SifirPilMi;
            Text = $"Hücre Verileri - {lot.LotAdi}";

            if (_sifirPil)
            {
                // Sıfır pil için tek satır
                numericAdet.Enabled = false;
                dataGridView.Rows.Clear();
                dataGridView.Rows.Add(1, "", "");
                lblAdet.Visible = false;
                numericAdet.Visible = false;
            }
            else
            {
                // Çıkma pil için adet kadar satır
                numericAdet.Maximum = lot.Adet;
                dataGridView.Rows.Clear();
                // Önceden girilmiş verileri kontrol et
                var mevcut = _context.PilHucres.Where(h => h.LotId == lot.Id).OrderBy(h => h.SeriNo).ToList();
                if (mevcut.Any())
                {
                    numericAdet.Enabled = false;
                    foreach (var h in mevcut)
                    {
                        dataGridView.Rows.Add(h.SeriNo, h.Kapasite, h.IcDirenc);
                    }
                }
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            // Önce mevcut hücreleri sil (eğer varsa)
            var mevcut = _context.PilHucres.Where(h => h.LotId == _lot.Id);
            _context.PilHucres.RemoveRange(mevcut);
            _context.SaveChanges();

            if (_sifirPil)
            {
                // Tek bir değer girilmiş, tüm hücrelere aynı değer atanacak
                if (dataGridView.Rows.Count < 1) return;
                var row = dataGridView.Rows[0];
                if (!decimal.TryParse(row.Cells[1].Value?.ToString(), out decimal kapasite) || kapasite <= 0)
                {
                    MessageBox.Show("Geçerli bir kapasite girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(row.Cells[2].Value?.ToString(), out decimal icDirenc) || icDirenc <= 0)
                {
                    MessageBox.Show("Geçerli bir iç direnç girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 1; i <= _lot.Adet; i++)
                {
                    var h = new PilHucresi
                    {
                        LotId = _lot.Id,
                        SeriNo = i,
                        Kapasite = kapasite,
                        IcDirenc = icDirenc,
                        Durum = "Stokta",
                        TestTarihi = DateTime.Now
                    };
                    _context.PilHucres.Add(h);
                }
            }
            else
            {
                // Çıkma pil: her satırda bir hücre
                int adetGirilen = dataGridView.Rows.Count - (dataGridView.AllowUserToAddRows ? 1 : 0);
                if (adetGirilen != _lot.Adet)
                {
                    MessageBox.Show($"Lot adedi {_lot.Adet} olarak girilmiş, ancak {adetGirilen} adet veri girildi. Lütfen tüm hücreler için veri girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < adetGirilen; i++)
                {
                    var row = dataGridView.Rows[i];
                    if (!decimal.TryParse(row.Cells[1].Value?.ToString(), out decimal kapasite) || kapasite <= 0)
                    {
                        MessageBox.Show($"Satır {i + 1}: Geçerli bir kapasite girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!decimal.TryParse(row.Cells[2].Value?.ToString(), out decimal icDirenc) || icDirenc <= 0)
                    {
                        MessageBox.Show($"Satır {i + 1}: Geçerli bir iç direnç girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var h = new PilHucresi
                    {
                        LotId = _lot.Id,
                        SeriNo = i + 1,
                        Kapasite = kapasite,
                        IcDirenc = icDirenc,
                        Durum = "Stokta",
                        TestTarihi = DateTime.Now
                    };
                    _context.PilHucres.Add(h);
                }
            }

            _context.SaveChanges();
            MessageBox.Show("Hücre verileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericAdet_ValueChanged(object sender, EventArgs e)
        {
            int adet = (int)numericAdet.Value;
            dataGridView.Rows.Clear();
            for (int i = 0; i < adet; i++)
            {
                dataGridView.Rows.Add(i + 1, "", "");
            }
        }

        private void PilHucresiGirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }

    partial class PilHucresiGirisForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView;
        private Button btnOlustur;
        private Button btnIptal;
        private Label lblAdet;
        private NumericUpDown numericAdet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView = new DataGridView();
            this.btnOlustur = new Button();
            this.btnIptal = new Button();
            this.lblAdet = new Label();
            this.numericAdet = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = true;
            this.dataGridView.AllowUserToDeleteRows = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "SeriNo", HeaderText = "Seri No", ReadOnly = true, Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Kapasite", HeaderText = "Kapasite (mAh)", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "IcDirenc", HeaderText = "İç Direnç (mΩ)", Width = 120 }
            });
            this.dataGridView.Location = new System.Drawing.Point(12, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(560, 300);
            this.dataGridView.TabIndex = 0;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(392, 360);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(100, 30);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Kaydet";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(502, 360);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 30);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(12, 20);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(86, 15);
            this.lblAdet.TabIndex = 3;
            this.lblAdet.Text = "Hücre Adedi:";
            // 
            // numericAdet
            // 
            this.numericAdet.Location = new System.Drawing.Point(104, 17);
            this.numericAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericAdet.Name = "numericAdet";
            this.numericAdet.Size = new System.Drawing.Size(100, 23);
            this.numericAdet.TabIndex = 4;
            this.numericAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericAdet.ValueChanged += new System.EventHandler(this.numericAdet_ValueChanged);
            // 
            // PilHucresiGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.Controls.Add(this.numericAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.dataGridView);
            this.Name = "PilHucresiGirisForm";
            this.Text = "Hücre Verileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PilHucresiGirisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}