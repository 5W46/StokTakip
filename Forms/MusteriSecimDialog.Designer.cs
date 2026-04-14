using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class MusteriSecimDialog
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewMusteriler;
        private TextBox txtAra;
        private Label label1;
        private Button btnSec;
        private Button btnIptal;

        private void InitializeComponent()
        {
            this.dataGridViewMusteriler = new DataGridView();
            this.txtAra = new TextBox();
            this.label1 = new Label();
            this.btnSec = new Button();
            this.btnIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.AllowUserToAddRows = false;
            this.dataGridViewMusteriler.AllowUserToDeleteRows = false;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriler.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "Ad", HeaderText = "Ad", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Soyad", HeaderText = "Soyad", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Telefon", HeaderText = "Telefon", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "Adres", HeaderText = "Adres", Width = 200 }
            });
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.ReadOnly = true;
            this.dataGridViewMusteriler.RowTemplate.Height = 25;
            this.dataGridViewMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(660, 350);
            this.dataGridViewMusteriler.TabIndex = 0;
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
            this.btnSec.Location = new System.Drawing.Point(450, 415);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(100, 30);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(572, 415);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 30);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // MusteriSecimDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridViewMusteriler);
            this.Name = "MusteriSecimDialog";
            this.Text = "Müşteri Seçimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}