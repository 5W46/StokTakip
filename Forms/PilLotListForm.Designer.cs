using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class PilLotListForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabLots;
        private TabPage tabBataryalar;
        private DataGridView dataGridViewLots;
        private DataGridView dataGridViewBataryalar;
        private Panel panelButtons;
        private Button btnYeniLot;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnBataryaGrupla;
        private Button btnSatildi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new TabControl();
            this.tabLots = new TabPage();
            this.dataGridViewLots = new DataGridView();
            this.tabBataryalar = new TabPage();
            this.dataGridViewBataryalar = new DataGridView();
            this.panelButtons = new Panel();
            this.btnSatildi = new Button();
            this.btnBataryaGrupla = new Button();
            this.btnSil = new Button();
            this.btnDuzenle = new Button();
            this.btnYeniLot = new Button();
            this.tabControl1.SuspendLayout();
            this.tabLots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLots)).BeginInit();
            this.tabBataryalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBataryalar)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLots);
            this.tabControl1.Controls.Add(this.tabBataryalar);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLots
            // 
            this.tabLots.Controls.Add(this.dataGridViewLots);
            this.tabLots.Location = new System.Drawing.Point(4, 24);
            this.tabLots.Name = "tabLots";
            this.tabLots.Padding = new Padding(3);
            this.tabLots.Size = new System.Drawing.Size(792, 372);
            this.tabLots.TabIndex = 0;
            this.tabLots.Text = "Pil Lotları";
            this.tabLots.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLots
            // 
            this.dataGridViewLots.AllowUserToAddRows = false;
            this.dataGridViewLots.AllowUserToDeleteRows = false;
            this.dataGridViewLots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLots.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "LotAdi", HeaderText = "Lot Adı", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "HucreModel", HeaderText = "Hücre Model", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "ToplamAdet", HeaderText = "Toplam Adet", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "StokAdet", HeaderText = "Stok Adet", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "BirimMaliyet", HeaderText = "Birim Maliyet", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "GirisTarihi", HeaderText = "Giriş Tarihi", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Tip", HeaderText = "Tip", Width = 80 }
            });
            this.dataGridViewLots.Dock = DockStyle.Fill;
            this.dataGridViewLots.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLots.Name = "dataGridViewLots";
            this.dataGridViewLots.ReadOnly = true;
            this.dataGridViewLots.Size = new System.Drawing.Size(786, 366);
            this.dataGridViewLots.TabIndex = 0;
            this.dataGridViewLots.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewLots_CellDoubleClick);
            // 
            // tabBataryalar
            // 
            this.tabBataryalar.Controls.Add(this.dataGridViewBataryalar);
            this.tabBataryalar.Location = new System.Drawing.Point(4, 24);
            this.tabBataryalar.Name = "tabBataryalar";
            this.tabBataryalar.Padding = new Padding(3);
            this.tabBataryalar.Size = new System.Drawing.Size(792, 372);
            this.tabBataryalar.TabIndex = 1;
            this.tabBataryalar.Text = "Yapılmış Bataryalar";
            this.tabBataryalar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBataryalar
            // 
            this.dataGridViewBataryalar.AllowUserToAddRows = false;
            this.dataGridViewBataryalar.AllowUserToDeleteRows = false;
            this.dataGridViewBataryalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBataryalar.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "BataryaAdi", HeaderText = "Batarya Adı", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Konfig", HeaderText = "Konfig", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Kapasite", HeaderText = "Kapasite (mAh)", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Maliyet", HeaderText = "Toplam Maliyet", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "SatisFiyati", HeaderText = "Satış Fiyatı", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Kar", HeaderText = "Kar", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Durum", HeaderText = "Durum", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "Tarih", HeaderText = "Oluşturma Tarihi", Width = 100 }
            });
            this.dataGridViewBataryalar.Dock = DockStyle.Fill;
            this.dataGridViewBataryalar.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBataryalar.Name = "dataGridViewBataryalar";
            this.dataGridViewBataryalar.ReadOnly = true;
            this.dataGridViewBataryalar.Size = new System.Drawing.Size(786, 366);
            this.dataGridViewBataryalar.TabIndex = 0;
            this.dataGridViewBataryalar.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewBataryalar_CellDoubleClick);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSatildi);
            this.panelButtons.Controls.Add(this.btnBataryaGrupla);
            this.panelButtons.Controls.Add(this.btnSil);
            this.panelButtons.Controls.Add(this.btnDuzenle);
            this.panelButtons.Controls.Add(this.btnYeniLot);
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 400);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(800, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // btnSatildi
            // 
            this.btnSatildi.Location = new System.Drawing.Point(472, 10);
            this.btnSatildi.Name = "btnSatildi";
            this.btnSatildi.Size = new System.Drawing.Size(100, 30);
            this.btnSatildi.TabIndex = 5;
            this.btnSatildi.Text = "Satıldı";
            this.btnSatildi.UseVisualStyleBackColor = true;
            this.btnSatildi.Visible = false;
            this.btnSatildi.Click += new System.EventHandler(this.btnSatildi_Click);
            // 
            // btnBataryaGrupla
            // 
            this.btnBataryaGrupla.Location = new System.Drawing.Point(342, 10);
            this.btnBataryaGrupla.Name = "btnBataryaGrupla";
            this.btnBataryaGrupla.Size = new System.Drawing.Size(120, 30);
            this.btnBataryaGrupla.TabIndex = 4;
            this.btnBataryaGrupla.Text = "Batarya Grupla";
            this.btnBataryaGrupla.UseVisualStyleBackColor = true;
            this.btnBataryaGrupla.Click += new System.EventHandler(this.btnBataryaGrupla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(232, 10);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(122, 10);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniLot
            // 
            this.btnYeniLot.Location = new System.Drawing.Point(12, 10);
            this.btnYeniLot.Name = "btnYeniLot";
            this.btnYeniLot.Size = new System.Drawing.Size(100, 30);
            this.btnYeniLot.TabIndex = 1;
            this.btnYeniLot.Text = "Yeni Lot";
            this.btnYeniLot.UseVisualStyleBackColor = true;
            this.btnYeniLot.Click += new System.EventHandler(this.btnYeniLot_Click);
            // 
            // PilLotListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelButtons);
            this.Name = "PilLotListForm";
            this.Text = "Batarya İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PilLotListForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabLots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLots)).EndInit();
            this.tabBataryalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBataryalar)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}