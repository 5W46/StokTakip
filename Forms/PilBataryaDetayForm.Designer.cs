using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class PilBataryaDetayForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabGenel;
        private TabPage tabGruplar;
        private Label label1;
        private TextBox txtBataryaAdi;
        private Label label2;
        private TextBox txtSeriParalel;
        private Label label3;
        private TextBox txtToplamKapasite;
        private Label label4;
        private TextBox txtOrtalamaKapasite;
        private Label label5;
        private TextBox txtToplamIcDirenc;
        private Label label6;
        private TextBox txtOrtalamaIcDirenc;
        private Label label7;
        private TextBox txtBMSMarka;
        private Label label8;
        private TextBox txtBMSModel;
        private Label label9;
        private TextBox txtPilMaliyeti;
        private Label label10;
        private TextBox txtSarfMalzemeler;
        private Label label11;
        private TextBox txtIsçilik;
        private Label label12;
        private TextBox txtToplamMaliyet;
        private Label label13;
        private TextBox txtSatisFiyati;
        private Label label14;
        private TextBox txtKar;
        private Label label15;
        private TextBox txtDurum;
        private Label label16;
        private TextBox txtOlusturmaTarihi;
        private Label label17;
        private TextBox txtSatisTarihi;
        private Label label18;
        private TextBox txtNotlar;
        private DataGridView dataGridViewHuceler;
        private DataGridView dataGridViewGruplar;
        private Button btnKapat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new TabControl();
            this.tabGenel = new TabPage();
            this.txtNotlar = new TextBox();
            this.label18 = new Label();
            this.txtSatisTarihi = new TextBox();
            this.label17 = new Label();
            this.txtOlusturmaTarihi = new TextBox();
            this.label16 = new Label();
            this.txtDurum = new TextBox();
            this.label15 = new Label();
            this.txtKar = new TextBox();
            this.label14 = new Label();
            this.txtSatisFiyati = new TextBox();
            this.label13 = new Label();
            this.txtToplamMaliyet = new TextBox();
            this.label12 = new Label();
            this.txtIsçilik = new TextBox();
            this.label11 = new Label();
            this.txtSarfMalzemeler = new TextBox();
            this.label10 = new Label();
            this.txtPilMaliyeti = new TextBox();
            this.label9 = new Label();
            this.txtBMSModel = new TextBox();
            this.label8 = new Label();
            this.txtBMSMarka = new TextBox();
            this.label7 = new Label();
            this.txtOrtalamaIcDirenc = new TextBox();
            this.label6 = new Label();
            this.txtToplamIcDirenc = new TextBox();
            this.label5 = new Label();
            this.txtOrtalamaKapasite = new TextBox();
            this.label4 = new Label();
            this.txtToplamKapasite = new TextBox();
            this.label3 = new Label();
            this.txtSeriParalel = new TextBox();
            this.label2 = new Label();
            this.txtBataryaAdi = new TextBox();
            this.label1 = new Label();
            this.tabGruplar = new TabPage();
            this.dataGridViewGruplar = new DataGridView();
            this.dataGridViewHuceler = new DataGridView();
            this.btnKapat = new Button();
            this.tabControl1.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabGruplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGruplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuceler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGenel);
            this.tabControl1.Controls.Add(this.tabGruplar);
            this.tabControl1.Dock = DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGenel
            // 
            this.tabGenel.AutoScroll = true;
            this.tabGenel.Controls.Add(this.txtNotlar);
            this.tabGenel.Controls.Add(this.label18);
            this.tabGenel.Controls.Add(this.txtSatisTarihi);
            this.tabGenel.Controls.Add(this.label17);
            this.tabGenel.Controls.Add(this.txtOlusturmaTarihi);
            this.tabGenel.Controls.Add(this.label16);
            this.tabGenel.Controls.Add(this.txtDurum);
            this.tabGenel.Controls.Add(this.label15);
            this.tabGenel.Controls.Add(this.txtKar);
            this.tabGenel.Controls.Add(this.label14);
            this.tabGenel.Controls.Add(this.txtSatisFiyati);
            this.tabGenel.Controls.Add(this.label13);
            this.tabGenel.Controls.Add(this.txtToplamMaliyet);
            this.tabGenel.Controls.Add(this.label12);
            this.tabGenel.Controls.Add(this.txtIsçilik);
            this.tabGenel.Controls.Add(this.label11);
            this.tabGenel.Controls.Add(this.txtSarfMalzemeler);
            this.tabGenel.Controls.Add(this.label10);
            this.tabGenel.Controls.Add(this.txtPilMaliyeti);
            this.tabGenel.Controls.Add(this.label9);
            this.tabGenel.Controls.Add(this.txtBMSModel);
            this.tabGenel.Controls.Add(this.label8);
            this.tabGenel.Controls.Add(this.txtBMSMarka);
            this.tabGenel.Controls.Add(this.label7);
            this.tabGenel.Controls.Add(this.txtOrtalamaIcDirenc);
            this.tabGenel.Controls.Add(this.label6);
            this.tabGenel.Controls.Add(this.txtToplamIcDirenc);
            this.tabGenel.Controls.Add(this.label5);
            this.tabGenel.Controls.Add(this.txtOrtalamaKapasite);
            this.tabGenel.Controls.Add(this.label4);
            this.tabGenel.Controls.Add(this.txtToplamKapasite);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.txtSeriParalel);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.txtBataryaAdi);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 24);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(692, 372);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel Bilgiler";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(120, 470);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.ReadOnly = true;
            this.txtNotlar.Size = new System.Drawing.Size(250, 60);
            this.txtNotlar.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 473);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 15);
            this.label18.TabIndex = 32;
            this.label18.Text = "Notlar:";
            // 
            // txtSatisTarihi
            // 
            this.txtSatisTarihi.Location = new System.Drawing.Point(120, 440);
            this.txtSatisTarihi.Name = "txtSatisTarihi";
            this.txtSatisTarihi.ReadOnly = true;
            this.txtSatisTarihi.Size = new System.Drawing.Size(150, 23);
            this.txtSatisTarihi.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 443);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 30;
            this.label17.Text = "Satış Tarihi:";
            // 
            // txtOlusturmaTarihi
            // 
            this.txtOlusturmaTarihi.Location = new System.Drawing.Point(120, 410);
            this.txtOlusturmaTarihi.Name = "txtOlusturmaTarihi";
            this.txtOlusturmaTarihi.ReadOnly = true;
            this.txtOlusturmaTarihi.Size = new System.Drawing.Size(150, 23);
            this.txtOlusturmaTarihi.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Oluşturma Tarihi:";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(120, 380);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.ReadOnly = true;
            this.txtDurum.Size = new System.Drawing.Size(150, 23);
            this.txtDurum.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Durum:";
            // 
            // txtKar
            // 
            this.txtKar.Location = new System.Drawing.Point(120, 350);
            this.txtKar.Name = "txtKar";
            this.txtKar.ReadOnly = true;
            this.txtKar.Size = new System.Drawing.Size(150, 23);
            this.txtKar.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Kar:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(120, 320);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.ReadOnly = true;
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 23);
            this.txtSatisFiyati.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Satış Fiyatı:";
            // 
            // txtToplamMaliyet
            // 
            this.txtToplamMaliyet.Location = new System.Drawing.Point(120, 290);
            this.txtToplamMaliyet.Name = "txtToplamMaliyet";
            this.txtToplamMaliyet.ReadOnly = true;
            this.txtToplamMaliyet.Size = new System.Drawing.Size(150, 23);
            this.txtToplamMaliyet.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Toplam Maliyet:";
            // 
            // txtIsçilik
            // 
            this.txtIsçilik.Location = new System.Drawing.Point(120, 260);
            this.txtIsçilik.Name = "txtIsçilik";
            this.txtIsçilik.ReadOnly = true;
            this.txtIsçilik.Size = new System.Drawing.Size(150, 23);
            this.txtIsçilik.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "İşçilik:";
            // 
            // txtSarfMalzemeler
            // 
            this.txtSarfMalzemeler.Location = new System.Drawing.Point(120, 230);
            this.txtSarfMalzemeler.Name = "txtSarfMalzemeler";
            this.txtSarfMalzemeler.ReadOnly = true;
            this.txtSarfMalzemeler.Size = new System.Drawing.Size(150, 23);
            this.txtSarfMalzemeler.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Sarf Malzemeler:";
            // 
            // txtPilMaliyeti
            // 
            this.txtPilMaliyeti.Location = new System.Drawing.Point(120, 200);
            this.txtPilMaliyeti.Name = "txtPilMaliyeti";
            this.txtPilMaliyeti.ReadOnly = true;
            this.txtPilMaliyeti.Size = new System.Drawing.Size(150, 23);
            this.txtPilMaliyeti.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Pil Maliyeti:";
            // 
            // txtBMSModel
            // 
            this.txtBMSModel.Location = new System.Drawing.Point(120, 170);
            this.txtBMSModel.Name = "txtBMSModel";
            this.txtBMSModel.ReadOnly = true;
            this.txtBMSModel.Size = new System.Drawing.Size(250, 23);
            this.txtBMSModel.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "BMS Model:";
            // 
            // txtBMSMarka
            // 
            this.txtBMSMarka.Location = new System.Drawing.Point(120, 140);
            this.txtBMSMarka.Name = "txtBMSMarka";
            this.txtBMSMarka.ReadOnly = true;
            this.txtBMSMarka.Size = new System.Drawing.Size(250, 23);
            this.txtBMSMarka.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "BMS Marka:";
            // 
            // txtOrtalamaIcDirenc
            // 
            this.txtOrtalamaIcDirenc.Location = new System.Drawing.Point(120, 110);
            this.txtOrtalamaIcDirenc.Name = "txtOrtalamaIcDirenc";
            this.txtOrtalamaIcDirenc.ReadOnly = true;
            this.txtOrtalamaIcDirenc.Size = new System.Drawing.Size(150, 23);
            this.txtOrtalamaIcDirenc.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ortalama İç Direnç:";
            // 
            // txtToplamIcDirenc
            // 
            this.txtToplamIcDirenc.Location = new System.Drawing.Point(120, 80);
            this.txtToplamIcDirenc.Name = "txtToplamIcDirenc";
            this.txtToplamIcDirenc.ReadOnly = true;
            this.txtToplamIcDirenc.Size = new System.Drawing.Size(150, 23);
            this.txtToplamIcDirenc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Toplam İç Direnç:";
            // 
            // txtOrtalamaKapasite
            // 
            this.txtOrtalamaKapasite.Location = new System.Drawing.Point(120, 50);
            this.txtOrtalamaKapasite.Name = "txtOrtalamaKapasite";
            this.txtOrtalamaKapasite.ReadOnly = true;
            this.txtOrtalamaKapasite.Size = new System.Drawing.Size(150, 23);
            this.txtOrtalamaKapasite.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ortalama Kapasite:";
            // 
            // txtToplamKapasite
            // 
            this.txtToplamKapasite.Location = new System.Drawing.Point(120, 20);
            this.txtToplamKapasite.Name = "txtToplamKapasite";
            this.txtToplamKapasite.ReadOnly = true;
            this.txtToplamKapasite.Size = new System.Drawing.Size(150, 23);
            this.txtToplamKapasite.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Kapasite:";
            // 
            // txtSeriParalel
            // 
            this.txtSeriParalel.Location = new System.Drawing.Point(120, 50);
            this.txtSeriParalel.Name = "txtSeriParalel";
            this.txtSeriParalel.ReadOnly = true;
            this.txtSeriParalel.Size = new System.Drawing.Size(150, 23);
            this.txtSeriParalel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Konfigürasyon:";
            // 
            // txtBataryaAdi
            // 
            this.txtBataryaAdi.Location = new System.Drawing.Point(120, 20);
            this.txtBataryaAdi.Name = "txtBataryaAdi";
            this.txtBataryaAdi.ReadOnly = true;
            this.txtBataryaAdi.Size = new System.Drawing.Size(250, 23);
            this.txtBataryaAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Batarya Adı:";
            // 
            // tabGruplar
            // 
            this.tabGruplar.Controls.Add(this.dataGridViewGruplar);
            this.tabGruplar.Controls.Add(this.dataGridViewHuceler);
            this.tabGruplar.Location = new System.Drawing.Point(4, 24);
            this.tabGruplar.Name = "tabGruplar";
            this.tabGruplar.Padding = new Padding(3);
            this.tabGruplar.Size = new System.Drawing.Size(692, 372);
            this.tabGruplar.TabIndex = 1;
            this.tabGruplar.Text = "Gruplar ve Hücreler";
            this.tabGruplar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGruplar
            // 
            this.dataGridViewGruplar.AllowUserToAddRows = false;
            this.dataGridViewGruplar.AllowUserToDeleteRows = false;
            this.dataGridViewGruplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGruplar.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "GrupNo", HeaderText = "Grup No", Width = 60 },
                new DataGridViewTextBoxColumn() { Name = "SeriNoList", HeaderText = "Hücre Seri No", Width = 200 },
                new DataGridViewTextBoxColumn() { Name = "OrtKapasite", HeaderText = "Ort. Kapasite (mAh)", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "OrtIcDirenc", HeaderText = "Ort. İç Direnç (mΩ)", Width = 120 }
            });
            this.dataGridViewGruplar.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewGruplar.Name = "dataGridViewGruplar";
            this.dataGridViewGruplar.ReadOnly = true;
            this.dataGridViewGruplar.Size = new System.Drawing.Size(670, 150);
            this.dataGridViewGruplar.TabIndex = 0;
            // 
            // dataGridViewHuceler
            // 
            this.dataGridViewHuceler.AllowUserToAddRows = false;
            this.dataGridViewHuceler.AllowUserToDeleteRows = false;
            this.dataGridViewHuceler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHuceler.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "SeriNo", HeaderText = "Seri No", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Kapasite", HeaderText = "Kapasite (mAh)", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "IcDirenc", HeaderText = "İç Direnç (mΩ)", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "LotAdi", HeaderText = "Lot Adı", Width = 150 }
            });
            this.dataGridViewHuceler.Location = new System.Drawing.Point(10, 170);
            this.dataGridViewHuceler.Name = "dataGridViewHuceler";
            this.dataGridViewHuceler.ReadOnly = true;
            this.dataGridViewHuceler.Size = new System.Drawing.Size(670, 190);
            this.dataGridViewHuceler.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(610, 410);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(80, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // PilBataryaDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.tabControl1);
            this.Name = "PilBataryaDetayForm";
            this.Text = "Batarya Detayları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PilBataryaDetayForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabGruplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGruplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuceler)).EndInit();
            this.ResumeLayout(false);
        }
    }
}