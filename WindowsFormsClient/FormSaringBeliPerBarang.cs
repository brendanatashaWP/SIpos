using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormSaringBeliPerBarang : Form
    {
        public FormSaringBeliPerBarang()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        String tgl1, tgl2;

        private void btnPreview_Click(object sender, EventArgs e)
        {
            tgl1 = dtpAwal.Value.ToString("yyyy-MM-dd");
            tgl2 = dtpAkhir.Value.ToString("yyy-MM-dd");

            String strsql = "select kodeBarang, namaBarang, sum(qty) qty, sum(jumlah) jumlah "
            + "from View_Nota_Beli_Lengkap " + 
            "where tanggal >= '" + tgl1 + "' and tanggal <= '" +
            tgl2 + "' " + "group by kodeBarang, namaBarang";

            tgl1 = dtpAwal.Value.ToString("dd-MMMM-yyyy");
            tgl2 = dtpAkhir.Value.ToString("dd-MMMM-yyyy");
            LapBeliPerBarang tampil = new LapBeliPerBarang("Periode tanggal: "+ tgl1 + "  s.d  " + tgl2, "Tanggal Cetak: " + DateTime.Now.ToString("dd-MMMM-yyyy"));
            Tabel beliPerBarang = new Tabel("View_Nota_Beli_Lengkap");
            beliPerBarang.isiDataTable(strsql);
            //beliPerBarang.getDT();
            
            MessageBox.Show(tgl1 + " , " + tgl2);
            tampil.getBindingSource().DataSource = beliPerBarang.getDT();
            //tampil.getBindingSource().Filter = "tanggal>= '" + tgl1 + "' and '" + tgl2 + "'";
            tampil.ShowDialog();
            tampil.Dispose();
        }

       


    }
}
