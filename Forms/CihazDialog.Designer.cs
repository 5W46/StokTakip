using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class CihazDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox txtMarkaModel;
        private Label label2;
        private TextBox txtSeriNo;
        private Label label3;
        private ComboBox cmbDurum;
        private Label label4;
        private TextBox txtAlisMaliyeti;
        private Label label6;
        private TextBox txtSatisFiyati;
        private Label label7;
        private TextBox txtNotlar;
        private Button btnOK;
        private Button btnCancel;
        private Label label8;
        private TextBox txtAlinanKisiAdSoyad;
        private Label label9;
        private TextBox txtAlinanKisiTelefon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.txtMarkaModel = new TextBox();
            this.label2 = new Label();
            this.txtSeriNo = new TextBox();
            this.label3 = new Label();
            this.cmbDurum = new ComboBox();
            this.label4 = new Label();
            this.txtAlisMaliyeti = new TextBox();
            this.label6 = new Label();
            this.txtSatisFiyati = new TextBox();
            this.label7 = new Label();
            this.txtNotlar = new TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.label8 = new Label();
            this.txtAlinanKisiAdSoyad = new TextBox();
            this.label9 = new Label();
            this.txtAlinanKisiTelefon = new TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka/Model:";
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.Location = new System.Drawing.Point(120, 27);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(280, 23);
            this.txtMarkaModel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seri No:";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(120, 57);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(280, 23);
            this.txtSeriNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durum:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDurum.Items.AddRange(new object[] {
                "Satışa hazır",
                "Parça/Onarım bekliyor"});
            this.cmbDurum.Location = new System.Drawing.Point(120, 87);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(280, 23);
            this.cmbDurum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alış Maliyeti:";
            // 
            // txtAlisMaliyeti
            // 
            this.txtAlisMaliyeti.Location = new System.Drawing.Point(120, 117);
            this.txtAlisMaliyeti.Name = "txtAlisMaliyeti";
            this.txtAlisMaliyeti.Size = new System.Drawing.Size(280, 23);
            this.txtAlisMaliyeti.TabIndex = 7;
            this.txtAlisMaliyeti.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tahmini Satış Fiyatı:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(120, 147);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(280, 23);
            this.txtSatisFiyati.TabIndex = 11;
            this.txtSatisFiyati.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notlar:";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(120, 177);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(280, 60);
            this.txtNotlar.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alınan Kişi Ad Soyad:";
            // 
            // txtAlinanKisiAdSoyad
            // 
            this.txtAlinanKisiAdSoyad.Location = new System.Drawing.Point(120, 247);
            this.txtAlinanKisiAdSoyad.Name = "txtAlinanKisiAdSoyad";
            this.txtAlinanKisiAdSoyad.Size = new System.Drawing.Size(280, 23);
            this.txtAlinanKisiAdSoyad.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Alınan Kişi Telefon:";
            // 
            // txtAlinanKisiTelefon
            // 
            this.txtAlinanKisiTelefon.Location = new System.Drawing.Point(120, 277);
            this.txtAlinanKisiTelefon.Name = "txtAlinanKisiTelefon";
            this.txtAlinanKisiTelefon.Size = new System.Drawing.Size(280, 23);
            this.txtAlinanKisiTelefon.TabIndex = 17;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(210, 320);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CihazDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 371);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAlinanKisiTelefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAlinanKisiAdSoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlisMaliyeti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarkaModel);
            this.Controls.Add(this.label1);
            this.Name = "CihazDialog";
            this.Text = "Cihaz Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}