namespace WindowsFormsClient
{
    partial class LapJualPerBarang
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
            this.View_Lap_Nota_JualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetLaporanNotaJual = new WindowsFormsClient.DataSetLaporanNotaJual();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_Lap_Nota_JualTableAdapter = new WindowsFormsClient.DataSetLaporanNotaJualTableAdapters.View_Lap_Nota_JualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_Lap_Nota_JualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLaporanNotaJual)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Lap_Nota_JualBindingSource
            // 
            this.View_Lap_Nota_JualBindingSource.DataMember = "View_Lap_Nota_Jual";
            this.View_Lap_Nota_JualBindingSource.DataSource = this.DataSetLaporanNotaJual;
            // 
            // DataSetLaporanNotaJual
            // 
            this.DataSetLaporanNotaJual.DataSetName = "DataSetLaporanNotaJual";
            this.DataSetLaporanNotaJual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_Lap_Nota_JualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsClient.LapJualPerBarang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_Lap_Nota_JualTableAdapter
            // 
            this.View_Lap_Nota_JualTableAdapter.ClearBeforeFill = true;
            // 
            // LapJualPerBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LapJualPerBarang";
            this.Text = "LapJualPerBarang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LapJualPerBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Lap_Nota_JualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLaporanNotaJual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_Lap_Nota_JualBindingSource;
        private DataSetLaporanNotaJual DataSetLaporanNotaJual;
        private DataSetLaporanNotaJualTableAdapters.View_Lap_Nota_JualTableAdapter View_Lap_Nota_JualTableAdapter;
    }
}