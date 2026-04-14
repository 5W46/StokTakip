using System.Windows.Forms;

namespace StokTakip.Forms
{
    partial class UrunGaleriForm
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowPanel;
        private TextBox txtAra;
        private Button btnAra;
        private Panel topPanel;

        private void InitializeComponent()
        {
            this.topPanel = new Panel();
            this.txtAra = new TextBox();
            this.btnAra = new Button();
            this.flowPanel = new FlowLayoutPanel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.txtAra);
            this.topPanel.Controls.Add(this.btnAra);
            this.topPanel.Dock = DockStyle.Top;
            this.topPanel.Height = 50;
            this.topPanel.Name = "topPanel";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 23);
            this.txtAra.TabIndex = 1;
            this.txtAra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyDown);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(220, 11);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 25);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 50);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(800, 490);
            this.flowPanel.TabIndex = 0;
            // 
            // UrunGaleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "UrunGaleriForm";
            this.Text = "Resimli Ürün Galerisi";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}