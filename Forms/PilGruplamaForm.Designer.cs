using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class PilGruplamaForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox txtSeriSayisi;
        private Label label2;
        private TextBox txtParalelSayisi;
        private Label label3;
        private ComboBox cmbTolerans;
        private Label label4;
        private TrackBar trackBarOncelik;
        private Label lblOncelik;
        private Button btnGrupla;
        private DataGridView dataGridViewSonuc;
        private Button btnOlustur;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.txtSeriSayisi = new TextBox();
            this.label2 = new Label();
            this.txtParalelSayisi = new TextBox();
            this.label3 = new Label();
            this.cmbTolerans = new ComboBox();
            this.label4 = new Label();
            this.trackBarOncelik = new TrackBar();
            this.lblOncelik = new Label();
            this.btnGrupla = new Button();
            this.dataGridViewSonuc = new DataGridView();
            this.btnOlustur = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOncelik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seri Sayısı:";
            // 
            // txtSeriSayisi
            // 
            this.txtSeriSayisi.Location = new System.Drawing.Point(100, 27);
            this.txtSeriSayisi.Name = "txtSeriSayisi";
            this.txtSeriSayisi.Size = new System.Drawing.Size(80, 23);
            this.txtSeriSayisi.TabIndex = 1;
            this.txtSeriSayisi.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paralel Sayısı:";
            // 
            // txtParalelSayisi
            // 
            this.txtParalelSayisi.Location = new System.Drawing.Point(100, 57);
            this.txtParalelSayisi.Name = "txtParalelSayisi";
            this.txtParalelSayisi.Size = new System.Drawing.Size(80, 23);
            this.txtParalelSayisi.TabIndex = 3;
            this.txtParalelSayisi.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "İç Direnç Toleransı:";
            // 
            // cmbTolerans
            // 
            this.cmbTolerans.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTolerans.Items.AddRange(new object[] {
                "Düşük %5",
                "Normal %10",
                "Yüksek %15"});
            this.cmbTolerans.Location = new System.Drawing.Point(130, 87);
            this.cmbTolerans.Name = "cmbTolerans";
            this.cmbTolerans.Size = new System.Drawing.Size(120, 23);
            this.cmbTolerans.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kapasite/İç Direnç:";
            // 
            // trackBarOncelik
            // 
            this.trackBarOncelik.Location = new System.Drawing.Point(130, 120);
            this.trackBarOncelik.Maximum = 100;
            this.trackBarOncelik.Name = "trackBarOncelik";
            this.trackBarOncelik.Size = new System.Drawing.Size(200, 45);
            this.trackBarOncelik.TabIndex = 7;
            this.trackBarOncelik.TickFrequency = 10;
            this.trackBarOncelik.Scroll += new System.EventHandler(this.trackBarOncelik_Scroll);
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Location = new System.Drawing.Point(340, 135);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(113, 15);
            this.lblOncelik.TabIndex = 8;
            this.lblOncelik.Text = "Kapasite / İç Direnç";
            // 
            // btnGrupla
            // 
            this.btnGrupla.Location = new System.Drawing.Point(400, 30);
            this.btnGrupla.Name = "btnGrupla";
            this.btnGrupla.Size = new System.Drawing.Size(100, 30);
            this.btnGrupla.TabIndex = 9;
            this.btnGrupla.Text = "Grupla";
            this.btnGrupla.UseVisualStyleBackColor = true;
            this.btnGrupla.Click += new System.EventHandler(this.btnGrupla_Click);
            // 
            // dataGridViewSonuc
            // 
            this.dataGridViewSonuc.AllowUserToAddRows = false;
            this.dataGridViewSonuc.AllowUserToDeleteRows = false;
            this.dataGridViewSonuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSonuc.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "GrupNo", HeaderText = "Grup No", Width = 60 },
                new DataGridViewTextBoxColumn() { Name = "SeriNoList", HeaderText = "Hücre Seri No", Width = 200 },
                new DataGridViewTextBoxColumn() { Name = "OrtKapasite", HeaderText = "Ort. Kapasite (mAh)", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "OrtIcDirenc", HeaderText = "Ort. İç Direnç (mΩ)", Width = 120 }
            });
            this.dataGridViewSonuc.Location = new System.Drawing.Point(20, 180);
            this.dataGridViewSonuc.Name = "dataGridViewSonuc";
            this.dataGridViewSonuc.ReadOnly = true;
            this.dataGridViewSonuc.Size = new System.Drawing.Size(560, 200);
            this.dataGridViewSonuc.TabIndex = 10;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Enabled = false;
            this.btnOlustur.Location = new System.Drawing.Point(480, 400);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(100, 30);
            this.btnOlustur.TabIndex = 11;
            this.btnOlustur.Text = "Batarya Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // PilGruplamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 451);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.dataGridViewSonuc);
            this.Controls.Add(this.btnGrupla);
            this.Controls.Add(this.lblOncelik);
            this.Controls.Add(this.trackBarOncelik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTolerans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParalelSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeriSayisi);
            this.Controls.Add(this.label1);
            this.Name = "PilGruplamaForm";
            this.Text = "Batarya Gruplama";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOncelik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}