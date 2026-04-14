using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class CihazDetayForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelLeft;
        private Panel panelRight;
        private GroupBox groupBoxYapilacaklar;
        private DataGridView dataGridViewYapilacaklar;
        private Button btnYeniGorev;
        private Button btnTamamla;
        private Button btnGorevSil;
        private GroupBox groupBoxHarcamalar;
        private DataGridView dataGridViewHarcamalar;
        private Button btnHarcamaEkle;
        private Button btnStoktanGider;
        private Button btnHarcamaDuzenle;
        private Button btnHarcamaSil;
        private Button btnKapat;
        private Label lblToplamHarcama;
        private Label lblKar;
        private Label label1;
        private Label label2;
        private Label lblCihazBilgi;
        private Label lblAlinanKisi;
        private Label lblSatilanKisi;
        private Panel panelRightTop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new Panel();
            this.lblSatilanKisi = new Label();
            this.lblAlinanKisi = new Label();
            this.lblCihazBilgi = new Label();
            this.groupBoxYapilacaklar = new GroupBox();
            this.dataGridViewYapilacaklar = new DataGridView();
            this.btnYeniGorev = new Button();
            this.btnTamamla = new Button();
            this.btnGorevSil = new Button();
            this.panelRight = new Panel();
            this.panelRightTop = new Panel();
            this.lblKar = new Label();
            this.label2 = new Label();
            this.lblToplamHarcama = new Label();
            this.label1 = new Label();
            this.groupBoxHarcamalar = new GroupBox();
            this.dataGridViewHarcamalar = new DataGridView();
            this.btnHarcamaEkle = new Button();
            this.btnStoktanGider = new Button();
            this.btnHarcamaDuzenle = new Button();
            this.btnHarcamaSil = new Button();
            this.btnKapat = new Button();
            this.panelLeft.SuspendLayout();
            this.groupBoxYapilacaklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYapilacaklar)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelRightTop.SuspendLayout();
            this.groupBoxHarcamalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHarcamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.Controls.Add(this.lblSatilanKisi);
            this.panelLeft.Controls.Add(this.lblAlinanKisi);
            this.panelLeft.Controls.Add(this.lblCihazBilgi);
            this.panelLeft.Controls.Add(this.groupBoxYapilacaklar);
            this.panelLeft.Controls.Add(this.btnYeniGorev);
            this.panelLeft.Controls.Add(this.btnTamamla);
            this.panelLeft.Controls.Add(this.btnGorevSil);
            this.panelLeft.Dock = DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(450, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // lblCihazBilgi
            // 
            this.lblCihazBilgi.AutoSize = true;
            this.lblCihazBilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCihazBilgi.Location = new System.Drawing.Point(10, 10);
            this.lblCihazBilgi.Name = "lblCihazBilgi";
            this.lblCihazBilgi.Size = new System.Drawing.Size(0, 15);
            this.lblCihazBilgi.TabIndex = 4;
            // 
            // lblAlinanKisi
            // 
            this.lblAlinanKisi.AutoSize = true;
            this.lblAlinanKisi.Location = new System.Drawing.Point(10, 40);
            this.lblAlinanKisi.Name = "lblAlinanKisi";
            this.lblAlinanKisi.Size = new System.Drawing.Size(0, 15);
            this.lblAlinanKisi.TabIndex = 5;
            // 
            // lblSatilanKisi
            // 
            this.lblSatilanKisi.AutoSize = true;
            this.lblSatilanKisi.Location = new System.Drawing.Point(10, 70);
            this.lblSatilanKisi.Name = "lblSatilanKisi";
            this.lblSatilanKisi.Size = new System.Drawing.Size(0, 15);
            this.lblSatilanKisi.TabIndex = 6;
            // 
            // groupBoxYapilacaklar
            // 
            this.groupBoxYapilacaklar.Controls.Add(this.dataGridViewYapilacaklar);
            this.groupBoxYapilacaklar.Location = new System.Drawing.Point(10, 100);
            this.groupBoxYapilacaklar.Name = "groupBoxYapilacaklar";
            this.groupBoxYapilacaklar.Size = new System.Drawing.Size(430, 330);
            this.groupBoxYapilacaklar.TabIndex = 0;
            this.groupBoxYapilacaklar.TabStop = false;
            this.groupBoxYapilacaklar.Text = "Yapılacaklar Listesi";
            // 
            // dataGridViewYapilacaklar
            // 
            this.dataGridViewYapilacaklar.AllowUserToAddRows = false;
            this.dataGridViewYapilacaklar.AllowUserToDeleteRows = false;
            this.dataGridViewYapilacaklar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYapilacaklar.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "Aciklama", HeaderText = "Açıklama", Width = 280 },
                new DataGridViewTextBoxColumn() { Name = "Durum", HeaderText = "Durum", Width = 80 }
            });
            this.dataGridViewYapilacaklar.Dock = DockStyle.Fill;
            this.dataGridViewYapilacaklar.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewYapilacaklar.Name = "dataGridViewYapilacaklar";
            this.dataGridViewYapilacaklar.ReadOnly = true;
            this.dataGridViewYapilacaklar.Size = new System.Drawing.Size(424, 308);
            this.dataGridViewYapilacaklar.TabIndex = 0;
            // 
            // btnYeniGorev
            // 
            this.btnYeniGorev.Location = new System.Drawing.Point(10, 440);
            this.btnYeniGorev.Name = "btnYeniGorev";
            this.btnYeniGorev.Size = new System.Drawing.Size(100, 30);
            this.btnYeniGorev.TabIndex = 1;
            this.btnYeniGorev.Text = "Yeni Görev";
            this.btnYeniGorev.UseVisualStyleBackColor = true;
            this.btnYeniGorev.Click += new System.EventHandler(this.btnYeniGorev_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(120, 440);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(100, 30);
            this.btnTamamla.TabIndex = 2;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnGorevSil
            // 
            this.btnGorevSil.Location = new System.Drawing.Point(230, 440);
            this.btnGorevSil.Name = "btnGorevSil";
            this.btnGorevSil.Size = new System.Drawing.Size(100, 30);
            this.btnGorevSil.TabIndex = 3;
            this.btnGorevSil.Text = "Sil";
            this.btnGorevSil.UseVisualStyleBackColor = true;
            this.btnGorevSil.Click += new System.EventHandler(this.btnGorevSil_Click);
            // 
            // panelRight
            // 
            this.panelRight.AutoScroll = true;
            this.panelRight.Controls.Add(this.panelRightTop);
            this.panelRight.Controls.Add(this.groupBoxHarcamalar);
            this.panelRight.Controls.Add(this.btnHarcamaEkle);
            this.panelRight.Controls.Add(this.btnStoktanGider);
            this.panelRight.Controls.Add(this.btnHarcamaDuzenle);
            this.panelRight.Controls.Add(this.btnHarcamaSil);
            this.panelRight.Controls.Add(this.btnKapat);
            this.panelRight.Dock = DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(450, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(550, 500);
            this.panelRight.TabIndex = 1;
            // 
            // panelRightTop
            // 
            this.panelRightTop.Controls.Add(this.lblKar);
            this.panelRightTop.Controls.Add(this.label2);
            this.panelRightTop.Controls.Add(this.lblToplamHarcama);
            this.panelRightTop.Controls.Add(this.label1);
            this.panelRightTop.Location = new System.Drawing.Point(10, 10);
            this.panelRightTop.Name = "panelRightTop";
            this.panelRightTop.Size = new System.Drawing.Size(530, 50);
            this.panelRightTop.TabIndex = 10;
            // 
            // lblKar
            // 
            this.lblKar.AutoSize = true;
            this.lblKar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKar.Location = new System.Drawing.Point(110, 25);
            this.lblKar.Name = "lblKar";
            this.lblKar.Size = new System.Drawing.Size(13, 15);
            this.lblKar.TabIndex = 7;
            this.lblKar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kar:";
            // 
            // lblToplamHarcama
            // 
            this.lblToplamHarcama.AutoSize = true;
            this.lblToplamHarcama.Location = new System.Drawing.Point(110, 5);
            this.lblToplamHarcama.Name = "lblToplamHarcama";
            this.lblToplamHarcama.Size = new System.Drawing.Size(13, 15);
            this.lblToplamHarcama.TabIndex = 6;
            this.lblToplamHarcama.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Toplam Harcama:";
            // 
            // groupBoxHarcamalar
            // 
            this.groupBoxHarcamalar.Controls.Add(this.dataGridViewHarcamalar);
            this.groupBoxHarcamalar.Location = new System.Drawing.Point(10, 100);
            this.groupBoxHarcamalar.Name = "groupBoxHarcamalar";
            this.groupBoxHarcamalar.Size = new System.Drawing.Size(530, 330);
            this.groupBoxHarcamalar.TabIndex = 0;
            this.groupBoxHarcamalar.TabStop = false;
            this.groupBoxHarcamalar.Text = "Harcamalar";
            // 
            // dataGridViewHarcamalar
            // 
            this.dataGridViewHarcamalar.AllowUserToAddRows = false;
            this.dataGridViewHarcamalar.AllowUserToDeleteRows = false;
            this.dataGridViewHarcamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHarcamalar.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "HarcamaAdi", HeaderText = "Harcama Adı", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Tutar", HeaderText = "Tutar", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Aciklama", HeaderText = "Açıklama", Width = 200 },
                new DataGridViewTextBoxColumn() { Name = "Tarih", HeaderText = "Tarih", Width = 120 }
            });
            this.dataGridViewHarcamalar.Dock = DockStyle.Fill;
            this.dataGridViewHarcamalar.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewHarcamalar.Name = "dataGridViewHarcamalar";
            this.dataGridViewHarcamalar.ReadOnly = true;
            this.dataGridViewHarcamalar.Size = new System.Drawing.Size(524, 308);
            this.dataGridViewHarcamalar.TabIndex = 0;
            // 
            // btnHarcamaEkle
            // 
            this.btnHarcamaEkle.Location = new System.Drawing.Point(10, 440);
            this.btnHarcamaEkle.Name = "btnHarcamaEkle";
            this.btnHarcamaEkle.Size = new System.Drawing.Size(100, 30);
            this.btnHarcamaEkle.TabIndex = 1;
            this.btnHarcamaEkle.Text = "Harcama Ekle";
            this.btnHarcamaEkle.UseVisualStyleBackColor = true;
            this.btnHarcamaEkle.Click += new System.EventHandler(this.btnHarcamaEkle_Click);
            // 
            // btnStoktanGider
            // 
            this.btnStoktanGider.Location = new System.Drawing.Point(120, 440);
            this.btnStoktanGider.Name = "btnStoktanGider";
            this.btnStoktanGider.Size = new System.Drawing.Size(100, 30);
            this.btnStoktanGider.TabIndex = 2;
            this.btnStoktanGider.Text = "Stoktan Gider";
            this.btnStoktanGider.UseVisualStyleBackColor = true;
            this.btnStoktanGider.Click += new System.EventHandler(this.btnStoktanGider_Click);
            // 
            // btnHarcamaDuzenle
            // 
            this.btnHarcamaDuzenle.Location = new System.Drawing.Point(230, 440);
            this.btnHarcamaDuzenle.Name = "btnHarcamaDuzenle";
            this.btnHarcamaDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnHarcamaDuzenle.TabIndex = 3;
            this.btnHarcamaDuzenle.Text = "Düzenle";
            this.btnHarcamaDuzenle.UseVisualStyleBackColor = true;
            this.btnHarcamaDuzenle.Click += new System.EventHandler(this.btnHarcamaDuzenle_Click);
            // 
            // btnHarcamaSil
            // 
            this.btnHarcamaSil.Location = new System.Drawing.Point(340, 440);
            this.btnHarcamaSil.Name = "btnHarcamaSil";
            this.btnHarcamaSil.Size = new System.Drawing.Size(100, 30);
            this.btnHarcamaSil.TabIndex = 4;
            this.btnHarcamaSil.Text = "Sil";
            this.btnHarcamaSil.UseVisualStyleBackColor = true;
            this.btnHarcamaSil.Click += new System.EventHandler(this.btnHarcamaSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(450, 440);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(80, 30);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // CihazDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "CihazDetayForm";
            this.Text = "Cihaz Detayları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CihazDetayForm_FormClosing);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.groupBoxYapilacaklar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYapilacaklar)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRightTop.ResumeLayout(false);
            this.panelRightTop.PerformLayout();
            this.groupBoxHarcamalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHarcamalar)).EndInit();
            this.ResumeLayout(false);
        }
    }
}