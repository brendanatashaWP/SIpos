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
    public partial class FormCariSupplier : Form
    {
        public FormCariSupplier()
        {
            InitializeComponent();
        }

        Tabel supplier = new Tabel("supplier");

        private void FormCariSupplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = supplier.getBs();
        }

        private void txtCariSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            supplier.getBs().Filter = "namaSupplier LIKE '%" + txtCariSupplier.Text + "%'";
        }

       
        private String kodeSupplier;

        public String getKode()
        {
            
            return kodeSupplier;
        }

        private void txtCariSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                dgvSupplier.Focus();
            }
        }

        private void dgvSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int baris = dgvSupplier.SelectedCells[0].RowIndex;
                kodeSupplier = dgvSupplier.Rows[baris].Cells[0].Value.ToString();
                MessageBox.Show(kodeSupplier.ToString());
                Close();
            }
        }
    }
}
