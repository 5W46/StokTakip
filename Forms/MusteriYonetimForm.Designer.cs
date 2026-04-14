using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class MusteriYonetimForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewMusteriler;
        private DataGridView dataGridViewSiparisler;
        private Button btnYeniMusteri;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnKapat;
        private Label label1;
        private TextBox txtAra;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewMusteriler = new DataGridView();
            this.dataGridViewSiparisler = new DataGridView();
            this.btnYeniMusteri = new Button();
            this.btnDuzenle = new Button();
            this.btnSil = new Button();
            this.btnKapat = new Button();
            this.label1 = new Label();
            this.txtAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
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
                new DataGridViewTextBoxColumn() { Name = "Email", HeaderText = "Email", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Adres", HeaderText = "Adres", Width = 200 }
            });
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.ReadOnly = true;
            this.dataGridViewMusteriler.RowTemplate.Height = 25;
            this.dataGridViewMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewMusteriler.TabIndex = 0;
            this.dataGridViewMusteriler.SelectionChanged += new System.EventHandler(this.dataGridViewMusteriler_SelectionChanged);
            // 
            // dataGridViewSiparisler
            // 
            this.dataGridViewSiparisler.AllowUserToAddRows = false;
            this.dataGridViewSiparisler.AllowUserToDeleteRows = false;
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "Sipariş No", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Tarih", HeaderText = "Tarih", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "Toplam", HeaderText = "Toplam", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "KargoNo", HeaderText = "Kargo No", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Detaylar", HeaderText = "Ürünler", Width = 300 }
            });
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(12, 320);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.ReadOnly = true;
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(760, 200);
            this.dataGridViewSiparisler.TabIndex = 1;
            this.dataGridViewSiparisler.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewSiparisler_CellDoubleClick);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Location = new System.Drawing.Point(12, 12);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(100, 30);
            this.btnYeniMusteri.TabIndex = 2;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(118, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(224, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(672, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arama:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(400, 15);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 23);
            this.txtAra.TabIndex = 7;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // MusteriYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.dataGridViewSiparisler);
            this.Controls.Add(this.dataGridViewMusteriler);
            this.Name = "MusteriYonetimForm";
            this.Text = "Müşteri Yönetimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusteriYonetimForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}