using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class PilBataryaOlusturForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox txtBataryaAdi;
        private Label label2;
        private Label lblHesaplanan;
        private Label label3;
        private TextBox txtBMSMarka;
        private Label label4;
        private TextBox txtBMSModel;
        private Label label5;
        private NumericUpDown numericPilMaliyeti;
        private Label label6;
        private NumericUpDown numericSarf;
        private Label label7;
        private NumericUpDown numericIsçilik;
        private Label label8;
        private NumericUpDown numericSatisFiyati;
        private Label label9;
        private TextBox txtNotlar;
        private Button btnKaydet;
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
            this.txtBataryaAdi = new TextBox();
            this.label2 = new Label();
            this.lblHesaplanan = new Label();
            this.label3 = new Label();
            this.txtBMSMarka = new TextBox();
            this.label4 = new Label();
            this.txtBMSModel = new TextBox();
            this.label5 = new Label();
            this.numericPilMaliyeti = new NumericUpDown();
            this.label6 = new Label();
            this.numericSarf = new NumericUpDown();
            this.label7 = new Label();
            this.numericIsçilik = new NumericUpDown();
            this.label8 = new Label();
            this.numericSatisFiyati = new NumericUpDown();
            this.label9 = new Label();
            this.txtNotlar = new TextBox();
            this.btnKaydet = new Button();
            this.btnIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPilMaliyeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIsçilik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSatisFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Batarya Adı:";
            // 
            // txtBataryaAdi
            // 
            this.txtBataryaAdi.Location = new System.Drawing.Point(100, 27);
            this.txtBataryaAdi.Name = "txtBataryaAdi";
            this.txtBataryaAdi.Size = new System.Drawing.Size(250, 23);
            this.txtBataryaAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesaplanan:";
            // 
            // lblHesaplanan
            // 
            this.lblHesaplanan.AutoSize = true;
            this.lblHesaplanan.Location = new System.Drawing.Point(100, 60);
            this.lblHesaplanan.Name = "lblHesaplanan";
            this.lblHesaplanan.Size = new System.Drawing.Size(0, 15);
            this.lblHesaplanan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "BMS Marka:";
            // 
            // txtBMSMarka
            // 
            this.txtBMSMarka.Location = new System.Drawing.Point(100, 97);
            this.txtBMSMarka.Name = "txtBMSMarka";
            this.txtBMSMarka.Size = new System.Drawing.Size(250, 23);
            this.txtBMSMarka.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "BMS Model:";
            // 
            // txtBMSModel
            // 
            this.txtBMSModel.Location = new System.Drawing.Point(100, 127);
            this.txtBMSModel.Name = "txtBMSModel";
            this.txtBMSModel.Size = new System.Drawing.Size(250, 23);
            this.txtBMSModel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pil Maliyeti:";
            // 
            // numericPilMaliyeti
            // 
            this.numericPilMaliyeti.DecimalPlaces = 2;
            this.numericPilMaliyeti.Location = new System.Drawing.Point(100, 157);
            this.numericPilMaliyeti.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericPilMaliyeti.Name = "numericPilMaliyeti";
            this.numericPilMaliyeti.Size = new System.Drawing.Size(120, 23);
            this.numericPilMaliyeti.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sarf Malzemeler:";
            // 
            // numericSarf
            // 
            this.numericSarf.DecimalPlaces = 2;
            this.numericSarf.Location = new System.Drawing.Point(120, 187);
            this.numericSarf.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericSarf.Name = "numericSarf";
            this.numericSarf.Size = new System.Drawing.Size(120, 23);
            this.numericSarf.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "İşçilik:";
            // 
            // numericIsçilik
            // 
            this.numericIsçilik.DecimalPlaces = 2;
            this.numericIsçilik.Location = new System.Drawing.Point(100, 217);
            this.numericIsçilik.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericIsçilik.Name = "numericIsçilik";
            this.numericIsçilik.Size = new System.Drawing.Size(120, 23);
            this.numericIsçilik.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Satış Fiyatı:";
            // 
            // numericSatisFiyati
            // 
            this.numericSatisFiyati.DecimalPlaces = 2;
            this.numericSatisFiyati.Location = new System.Drawing.Point(100, 247);
            this.numericSatisFiyati.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericSatisFiyati.Name = "numericSatisFiyati";
            this.numericSatisFiyati.Size = new System.Drawing.Size(120, 23);
            this.numericSatisFiyati.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Notlar:";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(100, 277);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(250, 60);
            this.txtNotlar.TabIndex = 17;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(270, 360);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 30);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(360, 360);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 30);
            this.btnIptal.TabIndex = 19;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // PilBataryaOlusturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 411);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericSatisFiyati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericIsçilik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericSarf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericPilMaliyeti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBMSModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBMSMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHesaplanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBataryaAdi);
            this.Controls.Add(this.label1);
            this.Name = "PilBataryaOlusturForm";
            this.Text = "Batarya Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.numericPilMaliyeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIsçilik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSatisFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}