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
    public partial class LapNotaBeli : Form
    {
        public LapNotaBeli()
        {
            InitializeComponent();
        }

        private void LapNotaBeli_Load(object sender, EventArgs e)
        {
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
