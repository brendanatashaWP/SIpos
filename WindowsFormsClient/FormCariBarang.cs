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
    public partial class FormCariBarang : Form
    {
        public FormCariBarang()
        {
            InitializeComponent();
        }

        Tabel barang = new Tabel("barang");

        private void FormCariBarang_Load(object sender, EventArgs e)
        {
            dgvBarang.DataSource = barang.getBs();
            if(caribarang == true)
                setdgvBarang();
        }

        private void txtNamaBarang_KeyUp(object sender, KeyEventArgs e)
        {
            barang.getBs().Filter = "namabarang LIKE '%" + txtNamaBarang.Text + "%'";
        }

        //terakhir sampe sini, belum dikirim ke formnotabeli

        private String kodeBarang;

        public String getKode()
        {
            return kodeBarang;
        }

        private void txtNamaBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                dgvBarang.Focus();
            }
        }

        private void dgvBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int row = dgvBarang.SelectedCells[0].RowIndex;
                kodeBarang = dgvBarang.Rows[row].Cells[0].Value.ToString();
                //MessageBox.Show(kodeBarang.ToString());
                Close();
            }
        }

        //sudah selesai.
        public bool caribarang = false;
        private void setdgvBarang()
        {
            dgvBarang.Columns[4].Visible = true;
        }

        //public int index()
        //{
        //    int idx = dgvBarang.CurrentRow.Index;
        //    return idx;
        //}
        
        
    }
}
