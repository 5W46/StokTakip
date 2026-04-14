using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class GelirGiderForm
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxRapor;
        private Label label1;
        private DateTimePicker dtpBaslangic;
        private Label label2;
        private DateTimePicker dtpBitis;
        private Button btnRaporGuncelle;
        private Label lblToplamGelir;
        private Label lblToplamGider;
        private Label lblNetKar;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewGiderler;
        private Button btnYeniGider;
        private Button btnDuzenle;
        private Button btnSil;
        private GroupBox groupBoxGiderler;
        private GroupBox groupBoxIslemler;
        private DataGridView dataGridViewIslemler;
        private Button btnPdfCikti;
        private ComboBox cmbFiltre;   // Yeni filtre combobox

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxRapor = new GroupBox();
            this.lblNetKar = new Label();
            this.lblToplamGider = new Label();
            this.lblToplamGelir = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.btnRaporGuncelle = new Button();
            this.dtpBitis = new DateTimePicker();
            this.label2 = new Label();
            this.dtpBaslangic = new DateTimePicker();
            this.label1 = new Label();
            this.dataGridViewGiderler = new DataGridView();
            this.btnYeniGider = new Button();
            this.btnDuzenle = new Button();
            this.btnSil = new Button();
            this.groupBoxGiderler = new GroupBox();
            this.groupBoxIslemler = new GroupBox();
            this.dataGridViewIslemler = new DataGridView();
            this.btnPdfCikti = new Button();
            this.cmbFiltre = new ComboBox();  // Filtre combo tanımı
            this.groupBoxRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiderler)).BeginInit();
            this.groupBoxGiderler.SuspendLayout();
            this.groupBoxIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRapor
            // 
            this.groupBoxRapor.Controls.Add(this.lblNetKar);
            this.groupBoxRapor.Controls.Add(this.lblToplamGider);
            this.groupBoxRapor.Controls.Add(this.lblToplamGelir);
            this.groupBoxRapor.Controls.Add(this.label5);
            this.groupBoxRapor.Controls.Add(this.label4);
            this.groupBoxRapor.Controls.Add(this.label3);
            this.groupBoxRapor.Controls.Add(this.btnRaporGuncelle);
            this.groupBoxRapor.Controls.Add(this.dtpBitis);
            this.groupBoxRapor.Controls.Add(this.label2);
            this.groupBoxRapor.Controls.Add(this.dtpBaslangic);
            this.groupBoxRapor.Controls.Add(this.label1);
            this.groupBoxRapor.Controls.Add(this.cmbFiltre);  // ComboBox eklendi
            this.groupBoxRapor.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRapor.Name = "groupBoxRapor";
            this.groupBoxRapor.Size = new System.Drawing.Size(860, 150);
            this.groupBoxRapor.TabIndex = 0;
            this.groupBoxRapor.TabStop = false;
            this.groupBoxRapor.Text = "Gelir / Gider Raporu";
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFiltre.Items.AddRange(new object[] {
                "Tüm İşlemler",
                "Sadece Gelirler",
                "Sadece Giderler",
                "Stok İşlemleri",
                "Scooter İşlemleri",
                "Batarya İşlemleri",
                "Manuel Giderler"});
            this.cmbFiltre.Location = new System.Drawing.Point(310, 25);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(150, 23);
            this.cmbFiltre.TabIndex = 11;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // lblNetKar
            // 
            this.lblNetKar.AutoSize = true;
            this.lblNetKar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNetKar.Location = new System.Drawing.Point(120, 110);
            this.lblNetKar.Name = "lblNetKar";
            this.lblNetKar.Size = new System.Drawing.Size(19, 21);
            this.lblNetKar.TabIndex = 10;
            this.lblNetKar.Text = "0";
            // 
            // lblToplamGider
            // 
            this.lblToplamGider.AutoSize = true;
            this.lblToplamGider.Location = new System.Drawing.Point(120, 80);
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Size = new System.Drawing.Size(13, 15);
            this.lblToplamGider.TabIndex = 9;
            this.lblToplamGider.Text = "0";
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(120, 50);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(13, 15);
            this.lblToplamGelir.TabIndex = 8;
            this.lblToplamGelir.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Net Kar / Zarar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Gider:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Gelir:";
            // 
            // btnRaporGuncelle
            // 
            this.btnRaporGuncelle.Location = new System.Drawing.Point(720, 20);
            this.btnRaporGuncelle.Name = "btnRaporGuncelle";
            this.btnRaporGuncelle.Size = new System.Drawing.Size(120, 30);
            this.btnRaporGuncelle.TabIndex = 4;
            this.btnRaporGuncelle.Text = "Raporu Güncelle";
            this.btnRaporGuncelle.UseVisualStyleBackColor = true;
            this.btnRaporGuncelle.Click += new System.EventHandler(this.btnRaporGuncelle_Click);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(520, 25);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(150, 23);
            this.dtpBitis.TabIndex = 3;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş:";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(120, 25);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(150, 23);
            this.dtpBaslangic.TabIndex = 1;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç:";
            // 
            // dataGridViewGiderler
            // 
            this.dataGridViewGiderler.AllowUserToAddRows = false;
            this.dataGridViewGiderler.AllowUserToDeleteRows = false;
            this.dataGridViewGiderler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiderler.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "Tarih", HeaderText = "Tarih", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Kategori", HeaderText = "Kategori", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Aciklama", HeaderText = "Açıklama", Width = 250 },
                new DataGridViewTextBoxColumn() { Name = "Tutar", HeaderText = "Tutar", Width = 100 }
            });
            this.dataGridViewGiderler.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewGiderler.Name = "dataGridViewGiderler";
            this.dataGridViewGiderler.ReadOnly = true;
            this.dataGridViewGiderler.Size = new System.Drawing.Size(840, 200);
            this.dataGridViewGiderler.TabIndex = 0;
            // 
            // btnYeniGider
            // 
            this.btnYeniGider.Location = new System.Drawing.Point(10, 230);
            this.btnYeniGider.Name = "btnYeniGider";
            this.btnYeniGider.Size = new System.Drawing.Size(100, 30);
            this.btnYeniGider.TabIndex = 1;
            this.btnYeniGider.Text = "Yeni Gider";
            this.btnYeniGider.UseVisualStyleBackColor = true;
            this.btnYeniGider.Click += new System.EventHandler(this.btnYeniGider_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(120, 230);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(230, 230);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBoxGiderler
            // 
            this.groupBoxGiderler.Controls.Add(this.dataGridViewGiderler);
            this.groupBoxGiderler.Controls.Add(this.btnSil);
            this.groupBoxGiderler.Controls.Add(this.btnDuzenle);
            this.groupBoxGiderler.Controls.Add(this.btnYeniGider);
            this.groupBoxGiderler.Location = new System.Drawing.Point(12, 180);
            this.groupBoxGiderler.Name = "groupBoxGiderler";
            this.groupBoxGiderler.Size = new System.Drawing.Size(860, 270);
            this.groupBoxGiderler.TabIndex = 1;
            this.groupBoxGiderler.TabStop = false;
            this.groupBoxGiderler.Text = "Giderler";
            // 
            // groupBoxIslemler
            // 
            this.groupBoxIslemler.Controls.Add(this.dataGridViewIslemler);
            this.groupBoxIslemler.Controls.Add(this.btnPdfCikti);
            this.groupBoxIslemler.Location = new System.Drawing.Point(12, 460);
            this.groupBoxIslemler.Name = "groupBoxIslemler";
            this.groupBoxIslemler.Size = new System.Drawing.Size(860, 300);
            this.groupBoxIslemler.TabIndex = 2;
            this.groupBoxIslemler.TabStop = false;
            this.groupBoxIslemler.Text = "İşlem Geçmişi (Gelir / Gider)";
            // 
            // dataGridViewIslemler
            // 
            this.dataGridViewIslemler.AllowUserToAddRows = false;
            this.dataGridViewIslemler.AllowUserToDeleteRows = false;
            this.dataGridViewIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIslemler.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Tarih", HeaderText = "Tarih", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Tur", HeaderText = "Tür", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Aciklama", HeaderText = "Açıklama", Width = 400 },
                new DataGridViewTextBoxColumn() { Name = "Tutar", HeaderText = "Tutar", Width = 100 }
            });
            this.dataGridViewIslemler.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewIslemler.Name = "dataGridViewIslemler";
            this.dataGridViewIslemler.ReadOnly = true;
            this.dataGridViewIslemler.Size = new System.Drawing.Size(840, 230);
            this.dataGridViewIslemler.TabIndex = 0;
            // 
            // btnPdfCikti
            // 
            this.btnPdfCikti.Location = new System.Drawing.Point(750, 260);
            this.btnPdfCikti.Name = "btnPdfCikti";
            this.btnPdfCikti.Size = new System.Drawing.Size(100, 30);
            this.btnPdfCikti.TabIndex = 1;
            this.btnPdfCikti.Text = "PDF Çıktısı";
            this.btnPdfCikti.UseVisualStyleBackColor = true;
            this.btnPdfCikti.Click += new System.EventHandler(this.btnPdfCikti_Click);
            // 
            // GelirGiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 771);
            this.Controls.Add(this.groupBoxIslemler);
            this.Controls.Add(this.groupBoxGiderler);
            this.Controls.Add(this.groupBoxRapor);
            this.Name = "GelirGiderForm";
            this.Text = "Gelir / Gider Modülü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GelirGiderForm_FormClosing);
            this.groupBoxRapor.ResumeLayout(false);
            this.groupBoxRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiderler)).EndInit();
            this.groupBoxGiderler.ResumeLayout(false);
            this.groupBoxIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).EndInit();
            this.ResumeLayout(false);
        }
    }
}