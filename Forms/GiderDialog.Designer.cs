using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class GiderDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private DateTimePicker dtpTarih;
        private Label label2;
        private TextBox txtKategori;
        private Label label3;
        private TextBox txtAciklama;
        private Label label4;
        private TextBox txtTutar;
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
            this.dtpTarih = new DateTimePicker();
            this.label2 = new Label();
            this.txtKategori = new TextBox();
            this.label3 = new Label();
            this.txtAciklama = new TextBox();
            this.label4 = new Label();
            this.txtTutar = new TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(100, 27);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 23);
            this.dtpTarih.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(100, 57);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(200, 23);
            this.txtKategori.TabIndex = 3;
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
            this.txtAciklama.Size = new System.Drawing.Size(200, 60);
            this.txtAciklama.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(100, 157);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(200, 23);
            this.txtTutar.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(140, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GiderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 251);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label1);
            this.Name = "GiderDialog";
            this.Text = "Gider Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}