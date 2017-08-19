namespace WindowsFormsClient
{
    partial class LapNotaBeli
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
            this.View_Nota_Beli_LengkapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotaBeliLengkapDataSet = new WindowsFormsClient.NotaBeliLengkapDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_Nota_Beli_LengkapTableAdapter = new WindowsFormsClient.NotaBeliLengkapDataSetTableAdapters.View_Nota_Beli_LengkapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_Nota_Beli_LengkapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaBeliLengkapDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Nota_Beli_LengkapBindingSource
            // 
            this.View_Nota_Beli_LengkapBindingSource.DataMember = "View_Nota_Beli_Lengkap";
            this.View_Nota_Beli_LengkapBindingSource.DataSource = this.NotaBeliLengkapDataSet;
            // 
            // NotaBeliLengkapDataSet
            // 
            this.NotaBeliLengkapDataSet.DataSetName = "NotaBeliLengkapDataSet";
            this.NotaBeliLengkapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNotaBeli";
            reportDataSource1.Value = this.View_Nota_Beli_LengkapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsClient.LapNotaBeli.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_Nota_Beli_LengkapTableAdapter
            // 
            this.View_Nota_Beli_LengkapTableAdapter.ClearBeforeFill = true;
            // 
            // LapNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LapNotaBeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LapNotaBeli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LapNotaBeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Nota_Beli_LengkapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaBeliLengkapDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_Nota_Beli_LengkapBindingSource;
        private NotaBeliLengkapDataSet NotaBeliLengkapDataSet;
        private NotaBeliLengkapDataSetTableAdapters.View_Nota_Beli_LengkapTableAdapter View_Nota_Beli_LengkapTableAdapter;
    }
}