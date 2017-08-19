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
    public partial class LapBeliPerBarang : Form
    {
        public LapBeliPerBarang(String batas, String cetak)
        {
            this.batas = batas;
            this.cetak = cetak;
            InitializeComponent();
        }

        private String batas;
        private String cetak;

        // kalo pindah komputer jangan lupa ganti report pathnya

        private void LapBeliPerBarang_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = 
                "D:\\72150001\\281116TERBARU_WindowsFormsClient_A_07112016_brenda\\WindowsFormsClient\\LapBeliperBarang.rdlc";
            ReportParameter[] p = new ReportParameter[2];
            p[0] = new ReportParameter("batasTanggal", this.batas, true);
            p[1] = new ReportParameter("tanggalCetak", this.cetak, true);
            reportViewer1.LocalReport.SetParameters(p);
            // TODO: This line of code loads data into the 'NotaBeliLengkapDataSet.View_Nota_Beli_Lengkap' table. You can move, or remove it, as needed.
            this.View_Nota_Beli_LengkapTableAdapter.Fill(this.NotaBeliLengkapDataSet.View_Nota_Beli_Lengkap);

            this.reportViewer1.RefreshReport();
        }

        public BindingSource getBindingSource()
        {
            return View_Nota_Beli_LengkapBindingSource;
        }
    }
}
