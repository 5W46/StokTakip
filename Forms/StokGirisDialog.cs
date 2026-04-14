using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class StokGirisDialog : Form
    {
        public int Miktar { get; private set; }
        public string Aciklama { get; private set; } = string.Empty;
        public string TedarikciAdi { get; private set; } = string.Empty;
        public string TedarikciTelefon { get; private set; } = string.Empty;

        public StokGirisDialog(int maxMiktar = 9999)
        {
            InitializeComponent();
            numericMiktar.Maximum = maxMiktar;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Miktar = (int)numericMiktar.Value;
            if (Miktar <= 0)
            {
                MessageBox.Show("Miktar pozitif olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Aciklama = txtAciklama.Text.Trim();
            TedarikciAdi = txtTedarikciAdi.Text.Trim();
            TedarikciTelefon = txtTedarikciTelefon.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    partial class StokGirisDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private NumericUpDown numericMiktar;
        private Label label2;
        private TextBox txtAciklama;
        private Label label3;
        private TextBox txtTedarikciAdi;
        private Label label4;
        private TextBox txtTedarikciTelefon;
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
            this.numericMiktar = new NumericUpDown();
            this.label2 = new Label();
            this.txtAciklama = new TextBox();
            this.label3 = new Label();
            this.txtTedarikciAdi = new TextBox();
            this.label4 = new Label();
            this.txtTedarikciTelefon = new TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miktar:";
            // 
            // numericMiktar
            // 
            this.numericMiktar.Location = new System.Drawing.Point(100, 27);
            this.numericMiktar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(120, 23);
            this.numericMiktar.TabIndex = 1;
            this.numericMiktar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(100, 57);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(250, 23);
            this.txtAciklama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi Adı:";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(100, 87);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(250, 23);
            this.txtTedarikciAdi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tedarikçi Telefon:";
            // 
            // txtTedarikciTelefon
            // 
            this.txtTedarikciTelefon.Location = new System.Drawing.Point(100, 117);
            this.txtTedarikciTelefon.Name = "txtTedarikciTelefon";
            this.txtTedarikciTelefon.Size = new System.Drawing.Size(250, 23);
            this.txtTedarikciTelefon.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(170, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StokGirisDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTedarikciTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTedarikciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericMiktar);
            this.Controls.Add(this.label1);
            this.Name = "StokGirisDialog";
            this.Text = "Stok Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}