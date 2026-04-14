using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class CihazForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabAktif;
        private TabPage tabSatilmis;
        private DataGridView dataGridViewAktif;
        private DataGridView dataGridViewSatilmis;
        private Button btnEkle;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnSatildi;
        private Button btnAktifeTasi;
        private Panel panelButtons;
        private TextBox txtAktifAra;
        private TextBox txtSatilmisAra;
        private Label labelAktifAra;
        private Label labelSatilmisAra;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new TabControl();
            this.tabAktif = new TabPage();
            this.labelAktifAra = new Label();
            this.txtAktifAra = new TextBox();
            this.dataGridViewAktif = new DataGridView();
            this.tabSatilmis = new TabPage();
            this.labelSatilmisAra = new Label();
            this.txtSatilmisAra = new TextBox();
            this.dataGridViewSatilmis = new DataGridView();
            this.panelButtons = new Panel();
            this.btnAktifeTasi = new Button();
            this.btnSatildi = new Button();
            this.btnSil = new Button();
            this.btnDuzenle = new Button();
            this.btnEkle = new Button();
            this.tabControl1.SuspendLayout();
            this.tabAktif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktif)).BeginInit();
            this.tabSatilmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatilmis)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAktif);
            this.tabControl1.Controls.Add(this.tabSatilmis);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAktif
            // 
            this.tabAktif.Controls.Add(this.labelAktifAra);
            this.tabAktif.Controls.Add(this.txtAktifAra);
            this.tabAktif.Controls.Add(this.dataGridViewAktif);
            this.tabAktif.Location = new System.Drawing.Point(4, 24);
            this.tabAktif.Name = "tabAktif";
            this.tabAktif.Padding = new Padding(3);
            this.tabAktif.Size = new System.Drawing.Size(976, 433);
            this.tabAktif.TabIndex = 0;
            this.tabAktif.Text = "Aktif Cihazlar";
            this.tabAktif.UseVisualStyleBackColor = true;
            // 
            // labelAktifAra
            // 
            this.labelAktifAra.AutoSize = true;
            this.labelAktifAra.Location = new System.Drawing.Point(700, 8);
            this.labelAktifAra.Name = "labelAktifAra";
            this.labelAktifAra.Size = new System.Drawing.Size(44, 15);
            this.labelAktifAra.TabIndex = 2;
            this.labelAktifAra.Text = "Arama:";
            // 
            // txtAktifAra
            // 
            this.txtAktifAra.Location = new System.Drawing.Point(750, 5);
            this.txtAktifAra.Name = "txtAktifAra";
            this.txtAktifAra.Size = new System.Drawing.Size(200, 23);
            this.txtAktifAra.TabIndex = 1;
            this.txtAktifAra.TextChanged += new System.EventHandler(this.txtAktifAra_TextChanged);
            // 
            // dataGridViewAktif
            // 
            this.dataGridViewAktif.AllowUserToAddRows = false;
            this.dataGridViewAktif.AllowUserToDeleteRows = false;
            this.dataGridViewAktif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktif.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "MarkaModel", HeaderText = "Marka/Model", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "SeriNo", HeaderText = "Seri No", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "Durum", HeaderText = "Durum", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "Alis", HeaderText = "Alış", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "SatisFiyat", HeaderText = "Satış Fiyatı", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Kar", HeaderText = "Kar", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Tarih", HeaderText = "Ekleme Tarihi", Width = 100 }
            });
            this.dataGridViewAktif.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewAktif.Name = "dataGridViewAktif";
            this.dataGridViewAktif.ReadOnly = true;
            this.dataGridViewAktif.RowTemplate.Height = 25;
            this.dataGridViewAktif.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAktif.Size = new System.Drawing.Size(964, 390);
            this.dataGridViewAktif.TabIndex = 0;
            // 
            // tabSatilmis
            // 
            this.tabSatilmis.Controls.Add(this.labelSatilmisAra);
            this.tabSatilmis.Controls.Add(this.txtSatilmisAra);
            this.tabSatilmis.Controls.Add(this.dataGridViewSatilmis);
            this.tabSatilmis.Location = new System.Drawing.Point(4, 24);
            this.tabSatilmis.Name = "tabSatilmis";
            this.tabSatilmis.Padding = new Padding(3);
            this.tabSatilmis.Size = new System.Drawing.Size(976, 433);
            this.tabSatilmis.TabIndex = 1;
            this.tabSatilmis.Text = "Satılmış Cihazlar";
            this.tabSatilmis.UseVisualStyleBackColor = true;
            // 
            // labelSatilmisAra
            // 
            this.labelSatilmisAra.AutoSize = true;
            this.labelSatilmisAra.Location = new System.Drawing.Point(700, 8);
            this.labelSatilmisAra.Name = "labelSatilmisAra";
            this.labelSatilmisAra.Size = new System.Drawing.Size(44, 15);
            this.labelSatilmisAra.TabIndex = 2;
            this.labelSatilmisAra.Text = "Arama:";
            // 
            // txtSatilmisAra
            // 
            this.txtSatilmisAra.Location = new System.Drawing.Point(750, 5);
            this.txtSatilmisAra.Name = "txtSatilmisAra";
            this.txtSatilmisAra.Size = new System.Drawing.Size(200, 23);
            this.txtSatilmisAra.TabIndex = 1;
            this.txtSatilmisAra.TextChanged += new System.EventHandler(this.txtSatilmisAra_TextChanged);
            // 
            // dataGridViewSatilmis
            // 
            this.dataGridViewSatilmis.AllowUserToAddRows = false;
            this.dataGridViewSatilmis.AllowUserToDeleteRows = false;
            this.dataGridViewSatilmis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatilmis.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "MarkaModel", HeaderText = "Marka/Model", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "SeriNo", HeaderText = "Seri No", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "SatisFiyati", HeaderText = "Satış Fiyatı", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Kar", HeaderText = "Kar", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "SatisTarihi", HeaderText = "Satış Tarihi", Width = 100 }
            });
            this.dataGridViewSatilmis.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewSatilmis.Name = "dataGridViewSatilmis";
            this.dataGridViewSatilmis.ReadOnly = true;
            this.dataGridViewSatilmis.RowTemplate.Height = 25;
            this.dataGridViewSatilmis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSatilmis.Size = new System.Drawing.Size(964, 390);
            this.dataGridViewSatilmis.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAktifeTasi);
            this.panelButtons.Controls.Add(this.btnSatildi);
            this.panelButtons.Controls.Add(this.btnSil);
            this.panelButtons.Controls.Add(this.btnDuzenle);
            this.panelButtons.Controls.Add(this.btnEkle);
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 461);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(984, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // btnAktifeTasi
            // 
            this.btnAktifeTasi.Location = new System.Drawing.Point(420, 12);
            this.btnAktifeTasi.Name = "btnAktifeTasi";
            this.btnAktifeTasi.Size = new System.Drawing.Size(140, 30);
            this.btnAktifeTasi.TabIndex = 4;
            this.btnAktifeTasi.Text = "Satılık Olarak İşaretle";
            this.btnAktifeTasi.UseVisualStyleBackColor = true;
            this.btnAktifeTasi.Visible = false;
            this.btnAktifeTasi.Click += new System.EventHandler(this.btnAktifeTasi_Click);
            // 
            // btnSatildi
            // 
            this.btnSatildi.Location = new System.Drawing.Point(420, 12);
            this.btnSatildi.Name = "btnSatildi";
            this.btnSatildi.Size = new System.Drawing.Size(100, 30);
            this.btnSatildi.TabIndex = 3;
            this.btnSatildi.Text = "Satıldı İşaretle";
            this.btnSatildi.UseVisualStyleBackColor = true;
            this.btnSatildi.Click += new System.EventHandler(this.btnSatildi_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(310, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(200, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(90, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 30);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Yeni Cihaz";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // CihazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelButtons);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "CihazForm";
            this.Text = "Scooter Takibi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CihazForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabAktif.ResumeLayout(false);
            this.tabAktif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktif)).EndInit();
            this.tabSatilmis.ResumeLayout(false);
            this.tabSatilmis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatilmis)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}