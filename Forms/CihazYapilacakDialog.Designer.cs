using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class CihazYapilacakDialog
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewYapilacaklar;
        private Button btnYeni;
        private Button btnTamamla;
        private Button btnSil;
        private Button btnKapat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewYapilacaklar = new DataGridView();
            this.btnYeni = new Button();
            this.btnTamamla = new Button();
            this.btnSil = new Button();
            this.btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYapilacaklar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewYapilacaklar
            // 
            this.dataGridViewYapilacaklar.AllowUserToAddRows = false;
            this.dataGridViewYapilacaklar.AllowUserToDeleteRows = false;
            this.dataGridViewYapilacaklar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYapilacaklar.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "Aciklama", HeaderText = "Açıklama", Width = 400 },
                new DataGridViewTextBoxColumn() { Name = "Durum", HeaderText = "Durum", Width = 80 }
            });
            this.dataGridViewYapilacaklar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewYapilacaklar.Name = "dataGridViewYapilacaklar";
            this.dataGridViewYapilacaklar.ReadOnly = true;
            this.dataGridViewYapilacaklar.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewYapilacaklar.TabIndex = 0;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(12, 320);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 30);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "Yeni Görev";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(120, 320);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(100, 30);
            this.btnTamamla.TabIndex = 2;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(230, 320);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(480, 320);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // CihazYapilacakDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.dataGridViewYapilacaklar);
            this.Name = "CihazYapilacakDialog";
            this.Text = "Yapılacaklar Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CihazYapilacakDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYapilacaklar)).EndInit();
            this.ResumeLayout(false);
        }
    }
}