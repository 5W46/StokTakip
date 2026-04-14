using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class StokForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelMain;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewHistory;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnStockIn;
        private Button btnStockOut;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.dataGridViewProducts);
            this.panelMain.Controls.Add(this.dataGridViewHistory);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.btnEdit);
            this.panelMain.Controls.Add(this.btnStockIn);
            this.panelMain.Controls.Add(this.btnStockOut);
            this.panelMain.Controls.Add(this.btnSearch);
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(884, 601);
            this.panelMain.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "Barkod", HeaderText = "Barkod", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "UrunAdi", HeaderText = "Ürün Adı", Width = 200 },
                new DataGridViewTextBoxColumn() { Name = "Stok", HeaderText = "Stok", Width = 70 },
                new DataGridViewTextBoxColumn() { Name = "MinStok", HeaderText = "Min Stok", Width = 70 },
                new DataGridViewTextBoxColumn() { Name = "Alis", HeaderText = "Alış", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Satis", HeaderText = "Satış", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Kar", HeaderText = "Kar", Width = 80 },
                new DataGridViewImageColumn() { Name = "Fotograf", HeaderText = "Resim", Width = 80, ImageLayout = DataGridViewImageCellLayout.Zoom }
            });
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(860, 300);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "Tarih", HeaderText = "Tarih", Width = 150 },
                new DataGridViewTextBoxColumn() { Name = "Tip", HeaderText = "Tip", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Miktar", HeaderText = "Miktar", Width = 80 },
                new DataGridViewTextBoxColumn() { Name = "Aciklama", HeaderText = "Açıklama", Width = 400 }
            });
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 390);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.Size = new System.Drawing.Size(860, 200);
            this.dataGridViewHistory.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Yeni Ürün";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(174, 12);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(75, 30);
            this.btnStockIn.TabIndex = 4;
            this.btnStockIn.Text = "Stok Giriş";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Location = new System.Drawing.Point(255, 12);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(75, 30);
            this.btnStockOut.TabIndex = 5;
            this.btnStockOut.Text = "Stok Çıkış";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(650, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(500, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 23);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stok Hareketleri";
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "StokForm";
            this.Text = "Stok Takibi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StokForm_FormClosing);
            this.Load += new System.EventHandler(this.StokForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
        }
    }
}