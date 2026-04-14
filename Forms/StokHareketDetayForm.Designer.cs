using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class StokHareketDetayForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label lblUrun;
        private Label label2;
        private Label lblTip;
        private Label label3;
        private Label lblMiktar;
        private Label label4;
        private Label lblTarih;
        private Label label5;
        private Label lblAciklama;
        private Panel panelTedarikci;
        private Label label6;
        private Label lblTedarikciAdi;
        private Label label7;
        private Label lblTedarikciTelefon;
        private Panel panelMusteri;
        private Label label8;
        private Label lblMusteriAdi;
        private Label label9;
        private Label lblMusteriTelefon;
        private Panel panelCihaz;
        private Label label10;
        private Label lblCihaz;
        private Button btnKapat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.lblUrun = new Label();
            this.label2 = new Label();
            this.lblTip = new Label();
            this.label3 = new Label();
            this.lblMiktar = new Label();
            this.label4 = new Label();
            this.lblTarih = new Label();
            this.label5 = new Label();
            this.lblAciklama = new Label();
            this.panelTedarikci = new Panel();
            this.label6 = new Label();
            this.lblTedarikciAdi = new Label();
            this.label7 = new Label();
            this.lblTedarikciTelefon = new Label();
            this.panelMusteri = new Panel();
            this.label8 = new Label();
            this.lblMusteriAdi = new Label();
            this.label9 = new Label();
            this.lblMusteriTelefon = new Label();
            this.panelCihaz = new Panel();
            this.label10 = new Label();
            this.lblCihaz = new Label();
            this.btnKapat = new Button();
            this.panelTedarikci.SuspendLayout();
            this.panelMusteri.SuspendLayout();
            this.panelCihaz.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün:";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(140, 30);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(13, 15);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(140, 60);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(13, 15);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(140, 90);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(13, 15);
            this.lblMiktar.TabIndex = 5;
            this.lblMiktar.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(140, 120);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(13, 15);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(140, 150);
            this.lblAciklama.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(13, 15);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "-";
            // 
            // panelTedarikci
            // 
            this.panelTedarikci.Controls.Add(this.label6);
            this.panelTedarikci.Controls.Add(this.lblTedarikciAdi);
            this.panelTedarikci.Controls.Add(this.label7);
            this.panelTedarikci.Controls.Add(this.lblTedarikciTelefon);
            this.panelTedarikci.Location = new System.Drawing.Point(20, 190);
            this.panelTedarikci.Name = "panelTedarikci";
            this.panelTedarikci.Size = new System.Drawing.Size(500, 80);
            this.panelTedarikci.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tedarikçi Adı:";
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.AutoSize = true;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(120, 10);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(13, 15);
            this.lblTedarikciAdi.TabIndex = 1;
            this.lblTedarikciAdi.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tedarikçi Telefon:";
            // 
            // lblTedarikciTelefon
            // 
            this.lblTedarikciTelefon.AutoSize = true;
            this.lblTedarikciTelefon.Location = new System.Drawing.Point(120, 40);
            this.lblTedarikciTelefon.Name = "lblTedarikciTelefon";
            this.lblTedarikciTelefon.Size = new System.Drawing.Size(13, 15);
            this.lblTedarikciTelefon.TabIndex = 3;
            this.lblTedarikciTelefon.Text = "-";
            // 
            // panelMusteri
            // 
            this.panelMusteri.Controls.Add(this.label8);
            this.panelMusteri.Controls.Add(this.lblMusteriAdi);
            this.panelMusteri.Controls.Add(this.label9);
            this.panelMusteri.Controls.Add(this.lblMusteriTelefon);
            this.panelMusteri.Location = new System.Drawing.Point(20, 190);
            this.panelMusteri.Name = "panelMusteri";
            this.panelMusteri.Size = new System.Drawing.Size(500, 80);
            this.panelMusteri.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Müşteri Adı:";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(120, 10);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(13, 15);
            this.lblMusteriAdi.TabIndex = 1;
            this.lblMusteriAdi.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Müşteri Telefon:";
            // 
            // lblMusteriTelefon
            // 
            this.lblMusteriTelefon.AutoSize = true;
            this.lblMusteriTelefon.Location = new System.Drawing.Point(120, 40);
            this.lblMusteriTelefon.Name = "lblMusteriTelefon";
            this.lblMusteriTelefon.Size = new System.Drawing.Size(13, 15);
            this.lblMusteriTelefon.TabIndex = 3;
            this.lblMusteriTelefon.Text = "-";
            // 
            // panelCihaz
            // 
            this.panelCihaz.Controls.Add(this.label10);
            this.panelCihaz.Controls.Add(this.lblCihaz);
            this.panelCihaz.Location = new System.Drawing.Point(20, 190);
            this.panelCihaz.Name = "panelCihaz";
            this.panelCihaz.Size = new System.Drawing.Size(500, 80);
            this.panelCihaz.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kullanılan Cihaz:";
            // 
            // lblCihaz
            // 
            this.lblCihaz.AutoSize = true;
            this.lblCihaz.Location = new System.Drawing.Point(120, 10);
            this.lblCihaz.Name = "lblCihaz";
            this.lblCihaz.Size = new System.Drawing.Size(13, 15);
            this.lblCihaz.TabIndex = 1;
            this.lblCihaz.Text = "-";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(440, 300);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // StokHareketDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 351);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panelCihaz);
            this.Controls.Add(this.panelMusteri);
            this.Controls.Add(this.panelTedarikci);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.label1);
            this.Name = "StokHareketDetayForm";
            this.Text = "Stok Hareketi Detayı";
            this.panelTedarikci.ResumeLayout(false);
            this.panelTedarikci.PerformLayout();
            this.panelMusteri.ResumeLayout(false);
            this.panelMusteri.PerformLayout();
            this.panelCihaz.ResumeLayout(false);
            this.panelCihaz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}