using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class UrunSecimDialog
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewUrunler;
        private TextBox txtAra;
        private Label label1;
        private Button btnSec;
        private Button btnIptal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewUrunler = new DataGridView();
            this.txtAra = new TextBox();
            this.label1 = new Label();
            this.btnSec = new Button();
            this.btnIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.AllowUserToAddRows = false;
            this.dataGridViewUrunler.AllowUserToDeleteRows = false;
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "Barkod", HeaderText = "Barkod", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "UrunAdi", HeaderText = "Ürün Adı", Width = 250 },
                new DataGridViewTextBoxColumn() { Name = "Fiyat", HeaderText = "Fiyat", Width = 100 },
                new DataGridViewImageColumn() { Name = "Resim", HeaderText = "Resim", Width = 80, ImageLayout = DataGridViewImageCellLayout.Zoom }
            });
            this.dataGridViewUrunler.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.ReadOnly = true;
            this.dataGridViewUrunler.RowTemplate.Height = 25;
            this.dataGridViewUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(660, 350);
            this.dataGridViewUrunler.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(70, 15);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(300, 23);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama:";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(480, 415);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(100, 30);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(590, 415);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 30);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // UrunSecimDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridViewUrunler);
            this.Name = "UrunSecimDialog";
            this.Text = "Ürün Seçimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}