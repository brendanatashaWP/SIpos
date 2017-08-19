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
    public partial class LapNotaJual : Form
    {
        public LapNotaJual()
        {
            InitializeComponent();
        }

        private void LapNotaJual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLaporanNotaJual.View_Lap_Nota_Jual' table. You can move, or remove it, as needed.
            this.View_Lap_Nota_JualTableAdapter.Fill(this.DataSetLaporanNotaJual.View_Lap_Nota_Jual);

            this.reportViewer1.RefreshReport();
        }

        public BindingSource getBindingSource()
        {
            return View_Lap_Nota_JualBindingSource;
        }
    }
}
