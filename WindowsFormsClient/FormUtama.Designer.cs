namespace WindowsFormsClient
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.setupUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jualToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianPerBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.penjualanPerBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupBarangToolStripMenuItem,
            this.setupSupplierToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setupUserToolStripMenuItem,
            this.toolStripMenuItem2,
            this.keluarToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // setupBarangToolStripMenuItem
            // 
            this.setupBarangToolStripMenuItem.Name = "setupBarangToolStripMenuItem";
            this.setupBarangToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.setupBarangToolStripMenuItem.Text = "Setup Barang";
            this.setupBarangToolStripMenuItem.Click += new System.EventHandler(this.setupBarangToolStripMenuItem_Click);
            // 
            // setupSupplierToolStripMenuItem
            // 
            this.setupSupplierToolStripMenuItem.Name = "setupSupplierToolStripMenuItem";
            this.setupSupplierToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.setupSupplierToolStripMenuItem.Text = "Setup Supplier";
            this.setupSupplierToolStripMenuItem.Click += new System.EventHandler(this.setupSupplierToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // setupUserToolStripMenuItem
            // 
            this.setupUserToolStripMenuItem.Name = "setupUserToolStripMenuItem";
            this.setupUserToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.setupUserToolStripMenuItem.Text = "Setup User";
            this.setupUserToolStripMenuItem.Click += new System.EventHandler(this.setupUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beliToolStripMenuItem,
            this.jualToolStripMenuItem,
            this.penjualanToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // beliToolStripMenuItem
            // 
            this.beliToolStripMenuItem.Name = "beliToolStripMenuItem";
            this.beliToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.beliToolStripMenuItem.Text = "Pembelian";
            this.beliToolStripMenuItem.Click += new System.EventHandler(this.beliToolStripMenuItem_Click);
            // 
            // jualToolStripMenuItem
            // 
            this.jualToolStripMenuItem.Name = "jualToolStripMenuItem";
            this.jualToolStripMenuItem.Size = new System.Drawing.Size(127, 6);
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembelianPerBarangToolStripMenuItem,
            this.toolStripMenuItem3,
            this.penjualanPerBarangToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // pembelianPerBarangToolStripMenuItem
            // 
            this.pembelianPerBarangToolStripMenuItem.Name = "pembelianPerBarangToolStripMenuItem";
            this.pembelianPerBarangToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pembelianPerBarangToolStripMenuItem.Text = "Pembelian PerBarang";
            this.pembelianPerBarangToolStripMenuItem.Click += new System.EventHandler(this.pembelianPerBarangToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 6);
            // 
            // penjualanPerBarangToolStripMenuItem
            // 
            this.penjualanPerBarangToolStripMenuItem.Name = "penjualanPerBarangToolStripMenuItem";
            this.penjualanPerBarangToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.penjualanPerBarangToolStripMenuItem.Text = "Penjualan PerBarang";
            this.penjualanPerBarangToolStripMenuItem.Click += new System.EventHandler(this.penjualanPerBarangToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Text = "FormUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setupUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beliToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator jualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianPerBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem penjualanPerBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}