using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class UrunDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox txtBarkod;
        private Label label2;
        private TextBox txtUrunAdi;
        private Label label3;
        private TextBox txtAlisFiyati;
        private Label label4;
        private TextBox txtSatisFiyati;
        private Label label5;
        private TextBox txtStokMiktari;
        private Label label6;
        private TextBox txtMinStok;
        private Label label7;
        private TextBox txtAciklama;
        private Button btnOK;
        private Button btnCancel;
        private Label labelAlinanYer;
        private TextBox txtAlinanYer;
        private Label labelAlinanNumara;
        private TextBox txtAlinanNumara;
        private GroupBox groupBoxResim;
        private PictureBox pictureBox;
        private Button btnResimSec;
        private Button btnResimTemizle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.txtBarkod = new TextBox();
            this.label2 = new Label();
            this.txtUrunAdi = new TextBox();
            this.label3 = new Label();
            this.txtAlisFiyati = new TextBox();
            this.label4 = new Label();
            this.txtSatisFiyati = new TextBox();
            this.label5 = new Label();
            this.txtStokMiktari = new TextBox();
            this.label6 = new Label();
            this.txtMinStok = new TextBox();
            this.label7 = new Label();
            this.txtAciklama = new TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.labelAlinanYer = new Label();
            this.txtAlinanYer = new TextBox();
            this.labelAlinanNumara = new Label();
            this.txtAlinanNumara = new TextBox();
            this.groupBoxResim = new GroupBox();
            this.pictureBox = new PictureBox();
            this.btnResimSec = new Button();
            this.btnResimTemizle = new Button();
            this.groupBoxResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(120, 27);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(250, 23);
            this.txtBarkod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 57);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(250, 23);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alış Fiyatı:";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(120, 87);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(250, 23);
            this.txtAlisFiyati.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(120, 117);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(250, 23);
            this.txtSatisFiyati.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stok Miktarı:";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(120, 147);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(250, 23);
            this.txtStokMiktari.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Min Stok:";
            // 
            // txtMinStok
            // 
            this.txtMinStok.Location = new System.Drawing.Point(120, 177);
            this.txtMinStok.Name = "txtMinStok";
            this.txtMinStok.Size = new System.Drawing.Size(250, 23);
            this.txtMinStok.TabIndex = 11;
            // 
            // labelAlinanYer
            // 
            this.labelAlinanYer.AutoSize = true;
            this.labelAlinanYer.Location = new System.Drawing.Point(30, 210);
            this.labelAlinanYer.Name = "labelAlinanYer";
            this.labelAlinanYer.Size = new System.Drawing.Size(63, 15);
            this.labelAlinanYer.TabIndex = 12;
            this.labelAlinanYer.Text = "Alınan Yer:";
            // 
            // txtAlinanYer
            // 
            this.txtAlinanYer.Location = new System.Drawing.Point(120, 207);
            this.txtAlinanYer.Name = "txtAlinanYer";
            this.txtAlinanYer.Size = new System.Drawing.Size(250, 23);
            this.txtAlinanYer.TabIndex = 13;
            // 
            // labelAlinanNumara
            // 
            this.labelAlinanNumara.AutoSize = true;
            this.labelAlinanNumara.Location = new System.Drawing.Point(30, 240);
            this.labelAlinanNumara.Name = "labelAlinanNumara";
            this.labelAlinanNumara.Size = new System.Drawing.Size(78, 15);
            this.labelAlinanNumara.TabIndex = 14;
            this.labelAlinanNumara.Text = "Alınan Numara:";
            // 
            // txtAlinanNumara
            // 
            this.txtAlinanNumara.Location = new System.Drawing.Point(120, 237);
            this.txtAlinanNumara.Name = "txtAlinanNumara";
            this.txtAlinanNumara.Size = new System.Drawing.Size(250, 23);
            this.txtAlinanNumara.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 267);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(250, 60);
            this.txtAciklama.TabIndex = 17;
            // 
            // groupBoxResim
            // 
            this.groupBoxResim.Controls.Add(this.pictureBox);
            this.groupBoxResim.Controls.Add(this.btnResimSec);
            this.groupBoxResim.Controls.Add(this.btnResimTemizle);
            this.groupBoxResim.Location = new System.Drawing.Point(400, 20);
            this.groupBoxResim.Name = "groupBoxResim";
            this.groupBoxResim.Size = new System.Drawing.Size(200, 200);
            this.groupBoxResim.TabIndex = 18;
            this.groupBoxResim.TabStop = false;
            this.groupBoxResim.Text = "Ürün Resmi";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(10, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(180, 120);
            this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(10, 155);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(80, 30);
            this.btnResimSec.TabIndex = 1;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnResimTemizle
            // 
            this.btnResimTemizle.Location = new System.Drawing.Point(100, 155);
            this.btnResimTemizle.Name = "btnResimTemizle";
            this.btnResimTemizle.Size = new System.Drawing.Size(80, 30);
            this.btnResimTemizle.TabIndex = 2;
            this.btnResimTemizle.Text = "Temizle";
            this.btnResimTemizle.UseVisualStyleBackColor = true;
            this.btnResimTemizle.Click += new System.EventHandler(this.btnResimTemizle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(170, 350);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UrunDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBoxResim);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlinanNumara);
            this.Controls.Add(this.labelAlinanNumara);
            this.Controls.Add(this.txtAlinanYer);
            this.Controls.Add(this.labelAlinanYer);
            this.Controls.Add(this.txtMinStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label1);
            this.Name = "UrunDialog";
            this.Text = "Ürün Bilgileri";
            this.groupBoxResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}