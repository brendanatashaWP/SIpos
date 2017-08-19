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
    public partial class SaringJualPerBarang : Form
    {
        public SaringJualPerBarang()
        {
            InitializeComponent();
        }

        
        String tgl1, tgl2;
        private void btnPreview_Click(object sender, EventArgs e)
        {
            tgl1 = dtpAwal.Value.ToString("yyyy-MM-dd");
            tgl2 = dtpAkhir.Value.ToString("yyy-MM-dd");

            String strsql = "select kodeBarang, namaBarang, sum(qty) qty, sum(jumlah) jumlah "
            + "from View_Lap_Nota_Jual " +
            "where tanggal >= '" + tgl1 + "' and tanggal <= '" +
            tgl2 + "' " + "group by kodeBarang, namaBarang";

            tgl1 = dtpAwal.Value.ToString("dd-MMMM-yyyy");
            tgl2 = dtpAkhir.Value.ToString("dd-MMMM-yyyy");
            LapJualPerBarang tampil = new LapJualPerBarang("Periode tanggal: " + tgl1 + "  s.d  " + tgl2, "Tanggal Cetak: " + DateTime.Now.ToString("dd-MMMM-yyyy"));
            Tabel jualPerBarang = new Tabel("View_Lap_Nota_Jual");
            jualPerBarang.isiDataTable(strsql);
            //beliPerBarang.getDT();

            MessageBox.Show(tgl1 + " , " + tgl2);
            tampil.getBindingSource().DataSource = jualPerBarang.getDT();
            //tampil.getBindingSource().Filter = "tanggal>= '" + tgl1 + "' and '" + tgl2 + "'";
            tampil.ShowDialog();
            tampil.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
