namespace StokTakip.Forms
{
    partial class MusteriDialog
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(30, 30);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(25, 15);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(90, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 23);
            this.txtAd.TabIndex = 1;
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(30, 60);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(42, 15);
            this.labelSoyad.TabIndex = 2;
            this.labelSoyad.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(90, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 23);
            this.txtSoyad.TabIndex = 3;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(30, 90);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(48, 15);
            this.labelTelefon.TabIndex = 4;
            this.labelTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(90, 87);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(250, 23);
            this.txtTelefon.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 120);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(30, 150);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(40, 15);
            this.labelAdres.TabIndex = 8;
            this.labelAdres.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(90, 147);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(250, 60);
            this.txtAdres.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(160, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MusteriDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 281);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.labelAd);
            this.Name = "MusteriDialog";
            this.Text = "Müşteri Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}