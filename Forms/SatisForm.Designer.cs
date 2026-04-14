using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class SatisForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelMain;
        private GroupBox groupBox2;
        private TextBox txtUrunAra;
        private Button btnUrunAra;
        private ListBox listUrunSonuclari;
        private Button btnResimliListe;
        private GroupBox groupBox1;
        private TextBox txtBarkod;
        private Button btnBarkodEkle;
        private GroupBox groupBox3;
        private DataGridView dgvSepet;
        private Label lblToplam;
        private GroupBox groupBox4;
        private Button btnYeniMusteri;
        private Button btnMusteriListesi;
        private Label lblMusteriBilgi;
        private GroupBox groupBox5;
        private TextBox txtKargoNo;
        private Label label6;
        private TextBox txtNotlar;
        private Label label7;
        private Button btnSatisKaydet;
        private DataGridViewTextBoxColumn ColUrunAdi;
        private DataGridViewTextBoxColumn ColMiktar;
        private DataGridViewTextBoxColumn ColBirimFiyat;
        private DataGridViewTextBoxColumn ColToplam;
        private DataGridViewButtonColumn ColSil;
        private TextBox txtIndirim;
        private Label labelIndirim;
        private TextBox txtKargoUcreti;
        private Label labelKargo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.listUrunSonuclari = new System.Windows.Forms.ListBox();
            this.btnResimliListe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnBarkodEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.ColUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblToplam = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnMusteriListesi = new System.Windows.Forms.Button();
            this.lblMusteriBilgi = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtKargoNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.labelIndirim = new System.Windows.Forms.Label();
            this.txtKargoUcreti = new System.Windows.Forms.TextBox();
            this.labelKargo = new System.Windows.Forms.Label();
            this.btnSatisKaydet = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.groupBox2);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.groupBox3);
            this.panelMain.Controls.Add(this.groupBox4);
            this.panelMain.Controls.Add(this.groupBox5);
            this.panelMain.Controls.Add(this.btnSatisKaydet);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(944, 641);
            this.panelMain.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUrunAra);
            this.groupBox2.Controls.Add(this.btnUrunAra);
            this.groupBox2.Controls.Add(this.listUrunSonuclari);
            this.groupBox2.Controls.Add(this.btnResimliListe);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Ara (İsim / Barkod)";
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(20, 25);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(200, 23);
            this.txtUrunAra.TabIndex = 2;
            this.txtUrunAra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrunAra_KeyDown);
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Location = new System.Drawing.Point(226, 24);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(60, 25);
            this.btnUrunAra.TabIndex = 1;
            this.btnUrunAra.Text = "Ara";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // listUrunSonuclari
            // 
            this.listUrunSonuclari.FormattingEnabled = true;
            this.listUrunSonuclari.ItemHeight = 15;
            this.listUrunSonuclari.Location = new System.Drawing.Point(20, 55);
            this.listUrunSonuclari.Name = "listUrunSonuclari";
            this.listUrunSonuclari.Size = new System.Drawing.Size(266, 154);
            this.listUrunSonuclari.TabIndex = 0;
            this.listUrunSonuclari.DoubleClick += new System.EventHandler(this.listUrunSonuclari_DoubleClick);
            // 
            // btnResimliListe
            // 
            this.btnResimliListe.Location = new System.Drawing.Point(20, 215);
            this.btnResimliListe.Name = "btnResimliListe";
            this.btnResimliListe.Size = new System.Drawing.Size(266, 25);
            this.btnResimliListe.TabIndex = 3;
            this.btnResimliListe.Text = "Resimli Liste ile Seç";
            this.btnResimliListe.UseVisualStyleBackColor = true;
            this.btnResimliListe.Click += new System.EventHandler(this.btnResimliListe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Controls.Add(this.btnBarkodEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkod ile Ekle";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(20, 30);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(200, 23);
            this.txtBarkod.TabIndex = 2;
            // 
            // btnBarkodEkle
            // 
            this.btnBarkodEkle.Location = new System.Drawing.Point(226, 29);
            this.btnBarkodEkle.Name = "btnBarkodEkle";
            this.btnBarkodEkle.Size = new System.Drawing.Size(60, 25);
            this.btnBarkodEkle.TabIndex = 1;
            this.btnBarkodEkle.Text = "Ekle";
            this.btnBarkodEkle.UseVisualStyleBackColor = true;
            this.btnBarkodEkle.Click += new System.EventHandler(this.btnBarkodEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSepet);
            this.groupBox3.Controls.Add(this.lblToplam);
            this.groupBox3.Location = new System.Drawing.Point(330, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 400);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sepet";
            // 
            // dgvSepet
            // 
            this.dgvSepet.AllowUserToAddRows = false;
            this.dgvSepet.AllowUserToDeleteRows = false;
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUrunAdi,
            this.ColMiktar,
            this.ColBirimFiyat,
            this.ColToplam,
            this.ColSil});
            this.dgvSepet.Location = new System.Drawing.Point(10, 25);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.RowTemplate.Height = 25;
            this.dgvSepet.Size = new System.Drawing.Size(580, 320);
            this.dgvSepet.TabIndex = 0;
            this.dgvSepet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepet_CellClick);
            this.dgvSepet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepet_CellEndEdit);
            // 
            // ColUrunAdi
            // 
            this.ColUrunAdi.HeaderText = "Ürün Adı";
            this.ColUrunAdi.Name = "ColUrunAdi";
            this.ColUrunAdi.ReadOnly = true;
            this.ColUrunAdi.Width = 200;
            // 
            // ColMiktar
            // 
            this.ColMiktar.HeaderText = "Miktar";
            this.ColMiktar.Name = "ColMiktar";
            this.ColMiktar.Width = 80;
            // 
            // ColBirimFiyat
            // 
            this.ColBirimFiyat.HeaderText = "Birim Fiyat";
            this.ColBirimFiyat.Name = "ColBirimFiyat";
            this.ColBirimFiyat.ReadOnly = true;
            this.ColBirimFiyat.Width = 100;
            // 
            // ColToplam
            // 
            this.ColToplam.HeaderText = "Toplam";
            this.ColToplam.Name = "ColToplam";
            this.ColToplam.ReadOnly = true;
            this.ColToplam.Width = 100;
            // 
            // ColSil
            // 
            this.ColSil.HeaderText = "";
            this.ColSil.Name = "ColSil";
            this.ColSil.Text = "Sil";
            this.ColSil.UseColumnTextForButtonValue = true;
            this.ColSil.Width = 50;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplam.Location = new System.Drawing.Point(400, 360);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(56, 21);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "0.00 TL";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnYeniMusteri);
            this.groupBox4.Controls.Add(this.btnMusteriListesi);
            this.groupBox4.Controls.Add(this.lblMusteriBilgi);
            this.groupBox4.Location = new System.Drawing.Point(12, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 150);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Müşteri Bilgileri";
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Location = new System.Drawing.Point(20, 25);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(120, 30);
            this.btnYeniMusteri.TabIndex = 0;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.Location = new System.Drawing.Point(150, 25);
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.Size = new System.Drawing.Size(120, 30);
            this.btnMusteriListesi.TabIndex = 1;
            this.btnMusteriListesi.Text = "Müşteri Listesi";
            this.btnMusteriListesi.UseVisualStyleBackColor = true;
            this.btnMusteriListesi.Click += new System.EventHandler(this.btnMusteriListesi_Click);
            // 
            // lblMusteriBilgi
            // 
            this.lblMusteriBilgi.AutoSize = true;
            this.lblMusteriBilgi.Location = new System.Drawing.Point(20, 70);
            this.lblMusteriBilgi.Name = "lblMusteriBilgi";
            this.lblMusteriBilgi.Size = new System.Drawing.Size(94, 15);
            this.lblMusteriBilgi.TabIndex = 2;
            this.lblMusteriBilgi.Text = "Müşteri seçilmedi.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtKargoNo);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtNotlar);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtIndirim);
            this.groupBox5.Controls.Add(this.labelIndirim);
            this.groupBox5.Controls.Add(this.txtKargoUcreti);
            this.groupBox5.Controls.Add(this.labelKargo);
            this.groupBox5.Location = new System.Drawing.Point(330, 420);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 170);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ek Bilgiler";
            // 
            // txtKargoNo
            // 
            this.txtKargoNo.Location = new System.Drawing.Point(100, 25);
            this.txtKargoNo.Name = "txtKargoNo";
            this.txtKargoNo.Size = new System.Drawing.Size(200, 23);
            this.txtKargoNo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kargo Takip:";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(100, 55);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(480, 23);
            this.txtNotlar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Notlar:";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(100, 90);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(100, 23);
            this.txtIndirim.TabIndex = 4;
            this.txtIndirim.Text = "0";
            this.txtIndirim.TextChanged += new System.EventHandler(this.txtIndirim_TextChanged);
            // 
            // labelIndirim
            // 
            this.labelIndirim.AutoSize = true;
            this.labelIndirim.Location = new System.Drawing.Point(20, 93);
            this.labelIndirim.Name = "labelIndirim";
            this.labelIndirim.Size = new System.Drawing.Size(50, 15);
            this.labelIndirim.TabIndex = 5;
            this.labelIndirim.Text = "İndirim:";
            // 
            // txtKargoUcreti
            // 
            this.txtKargoUcreti.Location = new System.Drawing.Point(100, 125);
            this.txtKargoUcreti.Name = "txtKargoUcreti";
            this.txtKargoUcreti.Size = new System.Drawing.Size(100, 23);
            this.txtKargoUcreti.TabIndex = 6;
            this.txtKargoUcreti.Text = "0";
            this.txtKargoUcreti.TextChanged += new System.EventHandler(this.txtKargoUcreti_TextChanged);
            // 
            // labelKargo
            // 
            this.labelKargo.AutoSize = true;
            this.labelKargo.Location = new System.Drawing.Point(20, 128);
            this.labelKargo.Name = "labelKargo";
            this.labelKargo.Size = new System.Drawing.Size(70, 15);
            this.labelKargo.TabIndex = 7;
            this.labelKargo.Text = "Kargo Ücreti:";
            // 
            // btnSatisKaydet
            // 
            this.btnSatisKaydet.BackColor = System.Drawing.Color.Green;
            this.btnSatisKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSatisKaydet.ForeColor = System.Drawing.Color.White;
            this.btnSatisKaydet.Location = new System.Drawing.Point(780, 600);
            this.btnSatisKaydet.Name = "btnSatisKaydet";
            this.btnSatisKaydet.Size = new System.Drawing.Size(150, 40);
            this.btnSatisKaydet.TabIndex = 5;
            this.btnSatisKaydet.Text = "Satışı Kaydet";
            this.btnSatisKaydet.UseVisualStyleBackColor = false;
            this.btnSatisKaydet.Click += new System.EventHandler(this.btnSatisKaydet_Click);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "SatisForm";
            this.Text = "Satış Modülü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SatisForm_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}