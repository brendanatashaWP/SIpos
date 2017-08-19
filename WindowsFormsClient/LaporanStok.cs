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
    public partial class LaporanStok : Form
    {
        public LaporanStok()
        {
            InitializeComponent();
        }

        public BindingSource getBarangBindingSource()
        {
            return BarangBindingSource;
        }

        private void LaporanStok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InventoryDataSet.Barang' table. You can move, or remove it, as needed.
            this.BarangTableAdapter.Fill(this.InventoryDataSet.Barang);

            this.reportViewer1.RefreshReport();
        }
    }
}
