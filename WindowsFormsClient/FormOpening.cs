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
    public partial class FormOpening : Form
    {
        public FormOpening()
        {
            InitializeComponent();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            FormBarang aktif = new FormBarang();
            aktif.ShowDialog();

        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            FormSupplier aktif = new FormSupplier();
            aktif.ShowDialog();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            FormNotaBeli aktif = new FormNotaBeli();
            aktif.ShowDialog();
        }

        private void btnJual_Click(object sender, EventArgs e)
        {
            FormNotaJual aktif = new FormNotaJual();
            aktif.ShowDialog();
        }
    }
}
