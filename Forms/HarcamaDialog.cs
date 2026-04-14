using System;
using System.Windows.Forms;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class HarcamaDialog : Form
    {
        public CihazHarcama Harcama { get; private set; }

        public HarcamaDialog(CihazHarcama? existing = null)
        {
            InitializeComponent();
            if (existing != null)
            {
                Harcama = existing;
                txtHarcamaAdi.Text = existing.HarcamaAdi;
                txtTutar.Text = existing.Tutar.ToString();
                txtAciklama.Text = existing.Aciklama;
            }
            else
            {
                Harcama = new CihazHarcama();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHarcamaAdi.Text))
            {
                MessageBox.Show("Harcama adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tutar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Harcama.HarcamaAdi = txtHarcamaAdi.Text.Trim();
            Harcama.Tutar = tutar;
            Harcama.Aciklama = string.IsNullOrWhiteSpace(txtAciklama.Text) ? null : txtAciklama.Text.Trim();
            Harcama.Tarih = DateTime.Now;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    partial class HarcamaDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox txtHarcamaAdi;
        private Label label2;
        private TextBox txtTutar;
        private Label label3;
        private TextBox txtAciklama;
        private Button btnOK;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.txtHarcamaAdi = new TextBox();
            this.label2 = new Label();
            this.txtTutar = new TextBox();
            this.label3 = new Label();
            this.txtAciklama = new TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcama Adı:";
            // 
            // txtHarcamaAdi
            // 
            this.txtHarcamaAdi.Location = new System.Drawing.Point(100, 27);
            this.txtHarcamaAdi.Name = "txtHarcamaAdi";
            this.txtHarcamaAdi.Size = new System.Drawing.Size(250, 23);
            this.txtHarcamaAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(100, 57);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(250, 23);
            this.txtTutar.TabIndex = 3;
            this.txtTutar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(100, 87);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(250, 60);
            this.txtAciklama.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(170, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // HarcamaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHarcamaAdi);
            this.Controls.Add(this.label1);
            this.Name = "HarcamaDialog";
            this.Text = "Harcama Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}