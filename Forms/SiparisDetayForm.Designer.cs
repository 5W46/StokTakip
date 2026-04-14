using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class SiparisDetayForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label lblMusteri;
        private DateTimePicker dtpTarih;
        private Label label2;
        private TextBox txtKargoNo;
        private Label label3;
        private TextBox txtNotlar;
        private Label label4;
        private TextBox txtIndirim;
        private Label label5;
        private TextBox txtKargoUcreti;
        private DataGridView dgvSepet;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnUrunEkle;
        private Button btnKapat;
        private Label lblToplamBrut;
        private Label lblIndirim;
        private Label lblKargo;
        private Label lblNetGelir;
        private Label lblMaliyet;
        private Label lblKar;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label6;  // Eksik olan label6 eklendi

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.lblMusteri = new Label();
            this.dtpTarih = new DateTimePicker();
            this.label2 = new Label();
            this.txtKargoNo = new TextBox();
            this.label3 = new Label();
            this.txtNotlar = new TextBox();
            this.label4 = new Label();
            this.txtIndirim = new TextBox();
            this.label5 = new Label();
            this.txtKargoUcreti = new TextBox();
            this.dgvSepet = new DataGridView();
            this.btnKaydet = new Button();
            this.btnSil = new Button();
            this.btnUrunEkle = new Button();
            this.btnKapat = new Button();
            this.lblToplamBrut = new Label();
            this.lblIndirim = new Label();
            this.lblKargo = new Label();
            this.lblNetGelir = new Label();
            this.lblMaliyet = new Label();
            this.lblKar = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label11 = new Label();
            this.label12 = new Label();
            this.label6 = new Label();  // label6 nesnesi oluşturuldu
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(130, 15);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(38, 15);
            this.lblMusteri.TabIndex = 1;
            this.lblMusteri.Text = "------";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(130, 80);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 23);
            this.dtpTarih.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih:";
            // 
            // txtKargoNo
            // 
            this.txtKargoNo.Location = new System.Drawing.Point(130, 115);
            this.txtKargoNo.Name = "txtKargoNo";
            this.txtKargoNo.Size = new System.Drawing.Size(200, 23);
            this.txtKargoNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kargo Takip:";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(130, 150);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(200, 50);
            this.txtNotlar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notlar:";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(130, 210);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(100, 23);
            this.txtIndirim.TabIndex = 9;
            this.txtIndirim.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "İndirim:";
            // 
            // txtKargoUcreti
            // 
            this.txtKargoUcreti.Location = new System.Drawing.Point(130, 245);
            this.txtKargoUcreti.Name = "txtKargoUcreti";
            this.txtKargoUcreti.Size = new System.Drawing.Size(100, 23);
            this.txtKargoUcreti.TabIndex = 11;
            this.txtKargoUcreti.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kargo Ücreti:";
            // 
            // dgvSepet
            // 
            this.dgvSepet.AllowUserToAddRows = false;
            this.dgvSepet.AllowUserToDeleteRows = false;
            this.dgvSepet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "UrunAdi", HeaderText = "Ürün Adı", Width = 200 },
                new DataGridViewTextBoxColumn() { Name = "Miktar", HeaderText = "Miktar", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "BirimFiyat", HeaderText = "Birim Fiyat", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Toplam", HeaderText = "Toplam", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Maliyet", HeaderText = "Maliyet", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Kar", HeaderText = "Kar", Width = 100 }
            });
            this.dgvSepet.Location = new System.Drawing.Point(12, 290);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.ReadOnly = true;
            this.dgvSepet.Size = new System.Drawing.Size(760, 200);
            this.dgvSepet.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(400, 500);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(510, 500);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Seçili Ürünü Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(620, 500);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(100, 30);
            this.btnUrunEkle.TabIndex = 15;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(730, 500);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 16;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblToplamBrut
            // 
            this.lblToplamBrut.AutoSize = true;
            this.lblToplamBrut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToplamBrut.Location = new System.Drawing.Point(410, 20);
            this.lblToplamBrut.Name = "lblToplamBrut";
            this.lblToplamBrut.Size = new System.Drawing.Size(14, 15);
            this.lblToplamBrut.TabIndex = 17;
            this.lblToplamBrut.Text = "0";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(410, 45);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(13, 15);
            this.lblIndirim.TabIndex = 18;
            this.lblIndirim.Text = "0";
            // 
            // lblKargo
            // 
            this.lblKargo.AutoSize = true;
            this.lblKargo.Location = new System.Drawing.Point(410, 70);
            this.lblKargo.Name = "lblKargo";
            this.lblKargo.Size = new System.Drawing.Size(13, 15);
            this.lblKargo.TabIndex = 19;
            this.lblKargo.Text = "0";
            // 
            // lblNetGelir
            // 
            this.lblNetGelir.AutoSize = true;
            this.lblNetGelir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNetGelir.Location = new System.Drawing.Point(410, 95);
            this.lblNetGelir.Name = "lblNetGelir";
            this.lblNetGelir.Size = new System.Drawing.Size(14, 15);
            this.lblNetGelir.TabIndex = 20;
            this.lblNetGelir.Text = "0";
            // 
            // lblMaliyet
            // 
            this.lblMaliyet.AutoSize = true;
            this.lblMaliyet.Location = new System.Drawing.Point(410, 120);
            this.lblMaliyet.Name = "lblMaliyet";
            this.lblMaliyet.Size = new System.Drawing.Size(13, 15);
            this.lblMaliyet.TabIndex = 21;
            this.lblMaliyet.Text = "0";
            // 
            // lblKar
            // 
            this.lblKar.AutoSize = true;
            this.lblKar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKar.Location = new System.Drawing.Point(410, 145);
            this.lblKar.Name = "lblKar";
            this.lblKar.Size = new System.Drawing.Size(14, 15);
            this.lblKar.TabIndex = 22;
            this.lblKar.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Brüt Toplam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "İndirim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Kargo Ücreti:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Net Gelir:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Maliyet:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Kar:";
            // 
            // SiparisDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 541);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblKar);
            this.Controls.Add(this.lblMaliyet);
            this.Controls.Add(this.lblNetGelir);
            this.Controls.Add(this.lblKargo);
            this.Controls.Add(this.lblIndirim);
            this.Controls.Add(this.lblToplamBrut);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.txtKargoUcreti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKargoNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.label1);
            this.Name = "SiparisDetayForm";
            this.Text = "Sipariş Detayları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SiparisDetayForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}