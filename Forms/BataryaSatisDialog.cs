using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class BataryaSatisDialog : Form
    {
        public decimal SatisFiyati { get; private set; }
        public string AliciAdSoyad { get; private set; } = string.Empty;
        public string AliciTelefon { get; private set; } = string.Empty;

        public BataryaSatisDialog(decimal varsayilanFiyat = 0)
        {
            InitializeComponent();
            txtFiyat.Text = varsayilanFiyat.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Geçerli bir satış fiyatı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SatisFiyati = fiyat;
            AliciAdSoyad = txtAdSoyad.Text.Trim();
            AliciTelefon = txtTelefon.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    partial class BataryaSatisDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox txtFiyat;
        private Label label2;
        private TextBox txtAdSoyad;
        private Label label3;
        private TextBox txtTelefon;
        private Button btnOK;
        private Button btnIptal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.txtFiyat = new TextBox();
            this.label2 = new Label();
            this.txtAdSoyad = new TextBox();
            this.label3 = new Label();
            this.txtTelefon = new TextBox();
            this.btnOK = new Button();
            this.btnIptal = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış Fiyatı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(120, 27);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 23);
            this.txtFiyat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alıcı Adı Soyadı:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(120, 57);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 23);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 87);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 23);
            this.txtTelefon.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(160, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(250, 130);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 30);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // BataryaSatisDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label1);
            this.Name = "BataryaSatisDialog";
            this.Text = "Batarya Satış Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}