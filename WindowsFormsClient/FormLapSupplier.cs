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
    public partial class FormLapSupplier : Form
    {
        public FormLapSupplier()
        {
            InitializeComponent();
        }

        private void FormLapSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InventoryDataSet.Supplier' table. You can move, or remove it, as needed.
            this.SupplierTableAdapter.Fill(this.InventoryDataSet.Supplier);

            this.reportViewer1.RefreshReport();
        }
    }
}
