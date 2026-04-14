using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class PilLotDialog
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabLot;
        private TabPage tabHuceler;
        private Label label1;
        private TextBox txtLotAdi;
        private Label label2;
        private TextBox txtHucreModel;
        private Label label3;
        private TextBox txtTedarikciAdi;
        private Label label4;
        private TextBox txtTedarikciTelefon;
        private Label label5;
        private TextBox txtBirimMaliyet;
        private Label label6;
        private NumericUpDown numericAdet;
        private CheckBox chkSifirPil;
        private Label label7;
        private TextBox txtNotlar;
        private DataGridView dataGridViewHuceler;
        private Button btnKaydet;   // İsim değiştirildi
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new TabControl();
            this.tabLot = new TabPage();
            this.txtNotlar = new TextBox();
            this.chkSifirPil = new CheckBox();
            this.numericAdet = new NumericUpDown();
            this.txtBirimMaliyet = new TextBox();
            this.txtTedarikciTelefon = new TextBox();
            this.txtTedarikciAdi = new TextBox();
            this.txtHucreModel = new TextBox();
            this.txtLotAdi = new TextBox();
            this.label7 = new Label();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.tabHuceler = new TabPage();
            this.dataGridViewHuceler = new DataGridView();
            this.btnKaydet = new Button();
            this.btnCancel = new Button();
            this.tabControl1.SuspendLayout();
            this.tabLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).BeginInit();
            this.tabHuceler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuceler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLot);
            this.tabControl1.Controls.Add(this.tabHuceler);
            this.tabControl1.Dock = DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLot
            // 
            this.tabLot.Controls.Add(this.txtNotlar);
            this.tabLot.Controls.Add(this.chkSifirPil);
            this.tabLot.Controls.Add(this.numericAdet);
            this.tabLot.Controls.Add(this.txtBirimMaliyet);
            this.tabLot.Controls.Add(this.txtTedarikciTelefon);
            this.tabLot.Controls.Add(this.txtTedarikciAdi);
            this.tabLot.Controls.Add(this.txtHucreModel);
            this.tabLot.Controls.Add(this.txtLotAdi);
            this.tabLot.Controls.Add(this.label7);
            this.tabLot.Controls.Add(this.label6);
            this.tabLot.Controls.Add(this.label5);
            this.tabLot.Controls.Add(this.label4);
            this.tabLot.Controls.Add(this.label3);
            this.tabLot.Controls.Add(this.label2);
            this.tabLot.Controls.Add(this.label1);
            this.tabLot.Location = new System.Drawing.Point(4, 24);
            this.tabLot.Name = "tabLot";
            this.tabLot.Padding = new Padding(3);
            this.tabLot.Size = new System.Drawing.Size(506, 322);
            this.tabLot.TabIndex = 0;
            this.tabLot.Text = "Lot Bilgileri";
            this.tabLot.UseVisualStyleBackColor = true;
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(120, 230);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(250, 60);
            this.txtNotlar.TabIndex = 14;
            // 
            // chkSifirPil
            // 
            this.chkSifirPil.AutoSize = true;
            this.chkSifirPil.Location = new System.Drawing.Point(120, 200);
            this.chkSifirPil.Name = "chkSifirPil";
            this.chkSifirPil.Size = new System.Drawing.Size(63, 19);
            this.chkSifirPil.TabIndex = 13;
            this.chkSifirPil.Text = "Sıfır Pil";
            this.chkSifirPil.UseVisualStyleBackColor = true;
            this.chkSifirPil.CheckedChanged += new System.EventHandler(this.chkSifirPil_CheckedChanged);
            // 
            // numericAdet
            // 
            this.numericAdet.Location = new System.Drawing.Point(120, 170);
            this.numericAdet.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numericAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericAdet.Name = "numericAdet";
            this.numericAdet.Size = new System.Drawing.Size(120, 23);
            this.numericAdet.TabIndex = 12;
            this.numericAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericAdet.ValueChanged += new System.EventHandler(this.numericAdet_ValueChanged);
            // 
            // txtBirimMaliyet
            // 
            this.txtBirimMaliyet.Location = new System.Drawing.Point(120, 140);
            this.txtBirimMaliyet.Name = "txtBirimMaliyet";
            this.txtBirimMaliyet.Size = new System.Drawing.Size(250, 23);
            this.txtBirimMaliyet.TabIndex = 11;
            this.txtBirimMaliyet.Text = "0";
            // 
            // txtTedarikciTelefon
            // 
            this.txtTedarikciTelefon.Location = new System.Drawing.Point(120, 110);
            this.txtTedarikciTelefon.Name = "txtTedarikciTelefon";
            this.txtTedarikciTelefon.Size = new System.Drawing.Size(250, 23);
            this.txtTedarikciTelefon.TabIndex = 10;
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(120, 80);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(250, 23);
            this.txtTedarikciAdi.TabIndex = 9;
            // 
            // txtHucreModel
            // 
            this.txtHucreModel.Location = new System.Drawing.Point(120, 50);
            this.txtHucreModel.Name = "txtHucreModel";
            this.txtHucreModel.Size = new System.Drawing.Size(250, 23);
            this.txtHucreModel.TabIndex = 8;
            // 
            // txtLotAdi
            // 
            this.txtLotAdi.Location = new System.Drawing.Point(120, 20);
            this.txtLotAdi.Name = "txtLotAdi";
            this.txtLotAdi.Size = new System.Drawing.Size(250, 23);
            this.txtLotAdi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Notlar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sıfır Pil Mi?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim Maliyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tedarikçi Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lot Adı:";
            // 
            // tabHuceler
            // 
            this.tabHuceler.Controls.Add(this.dataGridViewHuceler);
            this.tabHuceler.Location = new System.Drawing.Point(4, 24);
            this.tabHuceler.Name = "tabHuceler";
            this.tabHuceler.Padding = new Padding(3);
            this.tabHuceler.Size = new System.Drawing.Size(506, 322);
            this.tabHuceler.TabIndex = 1;
            this.tabHuceler.Text = "Hücre Verileri";
            this.tabHuceler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHuceler
            // 
            this.dataGridViewHuceler.AllowUserToAddRows = true;
            this.dataGridViewHuceler.AllowUserToDeleteRows = true;
            this.dataGridViewHuceler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHuceler.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "SeriNo", HeaderText = "Seri No", ReadOnly = true, Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Kapasite", HeaderText = "Kapasite (mAh)", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "IcDirenc", HeaderText = "İç Direnç (mΩ)", Width = 120 }
            });
            this.dataGridViewHuceler.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewHuceler.Name = "dataGridViewHuceler";
            this.dataGridViewHuceler.Size = new System.Drawing.Size(494, 310);
            this.dataGridViewHuceler.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(330, 360);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 30);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PilLotDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tabControl1);
            this.Name = "PilLotDialog";
            this.Text = "Pil Lot Bilgileri";
            this.tabControl1.ResumeLayout(false);
            this.tabLot.ResumeLayout(false);
            this.tabLot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).EndInit();
            this.tabHuceler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuceler)).EndInit();
            this.ResumeLayout(false);
        }
    }
}