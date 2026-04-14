using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tlpMain;
        private Panel leftPanel;
        private Panel rightPanel;
        private Button btnSatis;
        private Button btnScooter;
        private Button btnBatarya;
        private Button btnStok;
        private Button btnMusteriYonetim;
        private Button btnGelirGider;
        private GroupBox groupBoxUyarilar;
        private ListBox listStokUyarilari;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tlpMain = new TableLayoutPanel();
            this.leftPanel = new Panel();
            this.rightPanel = new Panel();
            this.btnSatis = new Button();
            this.btnScooter = new Button();
            this.btnBatarya = new Button();
            this.btnStok = new Button();
            this.btnMusteriYonetim = new Button();
            this.btnGelirGider = new Button();
            this.groupBoxUyarilar = new GroupBox();
            this.listStokUyarilari = new ListBox();
            this.tlpMain.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.groupBoxUyarilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            this.tlpMain.Controls.Add(this.leftPanel, 0, 0);
            this.tlpMain.Controls.Add(this.rightPanel, 1, 0);
            this.tlpMain.Dock = DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnSatis);
            this.leftPanel.Controls.Add(this.btnScooter);
            this.leftPanel.Controls.Add(this.btnBatarya);
            this.leftPanel.Controls.Add(this.btnStok);
            this.leftPanel.Controls.Add(this.btnMusteriYonetim);
            this.leftPanel.Controls.Add(this.btnGelirGider);
            this.leftPanel.Dock = DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(314, 444);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.groupBoxUyarilar);
            this.rightPanel.Dock = DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(323, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(474, 444);
            this.rightPanel.TabIndex = 1;
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(30, 30);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(250, 40);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "Satış Modülü";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnScooter
            // 
            this.btnScooter.Location = new System.Drawing.Point(30, 80);
            this.btnScooter.Name = "btnScooter";
            this.btnScooter.Size = new System.Drawing.Size(250, 40);
            this.btnScooter.TabIndex = 1;
            this.btnScooter.Text = "Scooter Takibi";
            this.btnScooter.UseVisualStyleBackColor = true;
            this.btnScooter.Click += new System.EventHandler(this.btnScooter_Click);
            // 
            // btnBatarya
            // 
            this.btnBatarya.Location = new System.Drawing.Point(30, 130);
            this.btnBatarya.Name = "btnBatarya";
            this.btnBatarya.Size = new System.Drawing.Size(250, 40);
            this.btnBatarya.TabIndex = 2;
            this.btnBatarya.Text = "Batarya İşlemleri";
            this.btnBatarya.UseVisualStyleBackColor = true;
            this.btnBatarya.Click += new System.EventHandler(this.btnBatarya_Click);
            // 
            // btnStok
            // 
            this.btnStok.Location = new System.Drawing.Point(30, 180);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(250, 40);
            this.btnStok.TabIndex = 3;
            this.btnStok.Text = "Stok Takibi";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnMusteriYonetim
            // 
            this.btnMusteriYonetim.Location = new System.Drawing.Point(30, 230);
            this.btnMusteriYonetim.Name = "btnMusteriYonetim";
            this.btnMusteriYonetim.Size = new System.Drawing.Size(250, 40);
            this.btnMusteriYonetim.TabIndex = 4;
            this.btnMusteriYonetim.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetim.UseVisualStyleBackColor = true;
            this.btnMusteriYonetim.Click += new System.EventHandler(this.btnMusteriYonetim_Click);
            // 
            // btnGelirGider
            // 
            this.btnGelirGider.Location = new System.Drawing.Point(30, 280);
            this.btnGelirGider.Name = "btnGelirGider";
            this.btnGelirGider.Size = new System.Drawing.Size(250, 40);
            this.btnGelirGider.TabIndex = 5;
            this.btnGelirGider.Text = "Gelir / Gider";
            this.btnGelirGider.UseVisualStyleBackColor = true;
            this.btnGelirGider.Click += new System.EventHandler(this.btnGelirGider_Click);
            // 
            // groupBoxUyarilar
            // 
            this.groupBoxUyarilar.Controls.Add(this.listStokUyarilari);
            this.groupBoxUyarilar.Dock = DockStyle.Fill;
            this.groupBoxUyarilar.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUyarilar.Name = "groupBoxUyarilar";
            this.groupBoxUyarilar.Size = new System.Drawing.Size(474, 444);
            this.groupBoxUyarilar.TabIndex = 0;
            this.groupBoxUyarilar.TabStop = false;
            this.groupBoxUyarilar.Text = "Stok Uyarıları (Kritik Seviye)";
            // 
            // listStokUyarilari
            // 
            this.listStokUyarilari.Dock = DockStyle.Fill;
            this.listStokUyarilari.FormattingEnabled = true;
            this.listStokUyarilari.ItemHeight = 15;
            this.listStokUyarilari.Location = new System.Drawing.Point(3, 19);
            this.listStokUyarilari.Name = "listStokUyarilari";
            this.listStokUyarilari.Size = new System.Drawing.Size(468, 422);
            this.listStokUyarilari.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.Text = "Stok Takip Programı";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.groupBoxUyarilar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}