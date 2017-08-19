using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsClient
{
    public partial class LapJualPerBarang : Form
    {
        public LapJualPerBarang(String batas, String cetak)
        {
            this.batas = batas;
            this.cetak = cetak;
            InitializeComponent();
        }

        private void LapJualPerBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLaporanNotaJual.View_Lap_Nota_Jual' table. You can move, or remove it, as needed.
            this.View_Lap_Nota_JualTableAdapter.Fill(this.DataSetLaporanNotaJual.View_Lap_Nota_Jual);
            reportViewer1.LocalReport.ReportPath = 
                "D:\\72150001\\281116TERBARU_WindowsFormsClient_A_07112016_brenda\\WindowsFormsClient\\LapJualPerBarang.rdlc";
            ReportParameter[] p = new ReportParameter[2];
            p[0] = new ReportParameter("batasCetak", this.batas, true);
            p[1] = new ReportParameter("tglCetak", this.cetak, true);
            reportViewer1.LocalReport.SetParameters(p);
            View_Lap_Nota_JualTableAdapter.Fill(this.DataSetLaporanNotaJual.View_Lap_Nota_Jual);
            this.reportViewer1.RefreshReport();
        }
        
        private String batas;
        private String cetak;

        public BindingSource getBindingSource()
        {
            return View_Lap_Nota_JualBindingSource;
        }

    }
}
