using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class PilGrupDetayForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewDetay;
        private Button btnKapat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewDetay = new DataGridView();
            this.btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetay
            // 
            this.dataGridViewDetay.AllowUserToAddRows = false;
            this.dataGridViewDetay.AllowUserToDeleteRows = false;
            this.dataGridViewDetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetay.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "SeriNo", HeaderText = "Seri No", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Kapasite", HeaderText = "Kapasite (mAh)", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "IcDirenc", HeaderText = "İç Direnç (mΩ)", Width = 120 }
            });
            this.dataGridViewDetay.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDetay.Name = "dataGridViewDetay";
            this.dataGridViewDetay.ReadOnly = true;
            this.dataGridViewDetay.Size = new System.Drawing.Size(360, 300);
            this.dataGridViewDetay.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(292, 320);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(80, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // PilGrupDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dataGridViewDetay);
            this.Name = "PilGrupDetayForm";
            this.Text = "Grup Detayları";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetay)).EndInit();
            this.ResumeLayout(false);
        }
    }
}