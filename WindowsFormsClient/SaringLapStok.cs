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
    public partial class SaringLapStok : Form
    {
        public SaringLapStok()
        {
            InitializeComponent();
        }
        Tabel barang = new Tabel("barang");
         
        private void SaringLapStok_Load(object sender, EventArgs e)
        {
            while (barang.getBs().Position < barang.getBs().Count-1)
            {
                cbKodeBarang1.Items.Add(((DataRowView)barang.getBs().Current).Row["kodeBarang"]);
                cbKodeBarang2.Items.Add(((DataRowView)barang.getBs().Current).Row["kodeBarang"]);
                barang.getBs().MoveNext();
            }
            cbKodeBarang1.Items.Add(((DataRowView)barang.getBs().Current).Row["kodeBarang"]);
            cbKodeBarang2.Items.Add(((DataRowView)barang.getBs().Current).Row["kodeBarang"]);
            cbKodeBarang2.Text = ((DataRowView)barang.getBs().Current).Row["kodeBarang"].ToString();
            barang.getBs().MoveFirst();
            cbKodeBarang1.Text = ((DataRowView)barang.getBs().Current).Row["kodeBarang"].ToString();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            LaporanStok formLaporanStok = new LaporanStok();
            String kd1, kd2;
            kd1 = cbKodeBarang1.Text;
            kd2 = cbKodeBarang2.Text;
            formLaporanStok.getBarangBindingSource().Filter = "kodeBarang >= " + kd1 + " AND " +
                "kodeBarang <= " + kd2;
            formLaporanStok.ShowDialog();
            formLaporanStok.Dispose();
        }

    }
}
