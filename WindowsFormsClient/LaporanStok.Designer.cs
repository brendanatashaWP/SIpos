namespace WindowsFormsClient
{
    partial class LaporanStok
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InventoryDataSet = new WindowsFormsClient.InventoryDataSet();
            this.BarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BarangTableAdapter = new WindowsFormsClient.InventoryDataSetTableAdapters.BarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetBarang";
            reportDataSource1.Value = this.BarangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsClient.LaporanStok.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(341, 134);
            this.reportViewer1.TabIndex = 0;
            // 
            // InventoryDataSet
            // 
            this.InventoryDataSet.DataSetName = "InventoryDataSet";
            this.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BarangBindingSource
            // 
            this.BarangBindingSource.DataMember = "Barang";
            this.BarangBindingSource.DataSource = this.InventoryDataSet;
            // 
            // BarangTableAdapter
            // 
            this.BarangTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 134);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanStok";
            this.Text = "LaporanStok";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BarangBindingSource;
        private InventoryDataSet InventoryDataSet;
        private InventoryDataSetTableAdapters.BarangTableAdapter BarangTableAdapter;
    }
}