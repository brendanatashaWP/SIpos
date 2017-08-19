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
    public partial class FormUtama : Form
    {
        public FormUtama(bool setBar, bool setSup, bool jual, bool beli, 
            bool lapStok, bool lapSup, bool lapBeli, bool lapJual, bool formUser, String nama)
        {
            InitializeComponent();
            if (setBar == false)
                setupBarangToolStripMenuItem.Enabled = false;
            if (setSup == false)
                setupSupplierToolStripMenuItem.Enabled = false;
            if (jual == false)
                penjualanToolStripMenuItem.Enabled = false;
            if (beli == false)
                beliToolStripMenuItem.Enabled = false;
            if (lapBeli == false)
                pembelianPerBarangToolStripMenuItem.Enabled = false;
            if (lapJual == false)
                penjualanPerBarangToolStripMenuItem.Enabled = false;
            if (formUser == false)
                setupUserToolStripMenuItem.Enabled = false;
            Text += " -- " + nama;
        }

        private void setupBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang tampil = new FormBarang();
            tampil.ShowDialog();
            tampil.Dispose();
        }

        private void setupSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier tampil = new FormSupplier();
            tampil.ShowDialog();
            tampil.Dispose();
        }

        private void setupUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManipulasiUser tampil = new FormManipulasiUser();
            tampil.ShowDialog();
            tampil.Dispose();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void beliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaBeli tampil = new FormNotaBeli();
            tampil.ShowDialog();
            tampil.Dispose();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaJual tampil = new FormNotaJual();
            tampil.ShowDialog();
            tampil.Dispose();
        }

        private void pembelianPerBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaringBeliPerBarang tampil = new FormSaringBeliPerBarang();
            tampil.ShowDialog();
            tampil.Dispose();
        }

        private void penjualanPerBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaringJualPerBarang tampil = new SaringJualPerBarang();
            tampil.ShowDialog();
            tampil.Dispose();
        }

    }
}
