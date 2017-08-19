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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        Tabel supplier = new Tabel("supplier");
        bool baru;
        String kodeLama;
        private void setkodeLama(string kodelama)
        {
            kodeLama = kodelama;
        }
        private string getkodeLama()
        {
            return this.kodeLama;
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = supplier.getBs();
            modeSave();
        }

        private void modeEdit()
        {
            tbAlamat.Enabled = true;
            tbKode.Enabled = true;
            tbKota.Enabled = true;
            tbnamaSupplier.Enabled = true;
            tbTelepon.Enabled = true;
            BtnTop.Enabled = false;
            BtnBack.Enabled = false;
            BtnNext.Enabled = false;
            BtnEnd.Enabled = false;
            BtnPrint.Enabled = false;
            BtnFind.Enabled = false;
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Visible = true; //<-- visible-nya
            BtnUndo.Visible = true; //<-- visible-nya
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            BtnDel.Enabled = false;
            BtnClose.Enabled = false;
            tbKode.Focus();
            lepas();
        }

        private void modeSave()
        {
            tbAlamat.Enabled = false;
            tbKode.Enabled = false;
            tbKota.Enabled = false;
            tbnamaSupplier.Enabled = false;
            tbTelepon.Enabled = false;
            BtnTop.Enabled = true;
            BtnBack.Enabled = true;
            BtnNext.Enabled = true;
            BtnEnd.Enabled = true;
            BtnPrint.Enabled = true;
            BtnFind.Enabled = true;
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSave.Visible = false; //<-- visible-nya
            BtnUndo.Visible = false; //<-- visible-nya
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            BtnDel.Enabled = true;
            BtnClose.Enabled = true;
            ikat();
        }

        private void ikat()
        {
            tbAlamat.DataBindings.Add("Text", supplier.getBs(), "Alamat");
            tbKode.DataBindings.Add("Text", supplier.getBs(), "kodeSupplier");
            tbKota.DataBindings.Add("Text", supplier.getBs(), "kota");
            tbnamaSupplier.DataBindings.Add("Text", supplier.getBs(), "namaSupplier");
            tbTelepon.DataBindings.Add("Text", supplier.getBs(), "telpon");
        }

        private void lepas()
        {
            tbAlamat.DataBindings.Clear();
            tbKode.DataBindings.Clear();
            tbKota.DataBindings.Clear();
            tbnamaSupplier.DataBindings.Clear();
            tbTelepon.DataBindings.Clear();

        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            supplier.getBs().MoveFirst();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            supplier.getBs().MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            supplier.getBs().MoveNext();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            supplier.getBs().MoveLast();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            setkodeLama(tbKode.Text);
            modeEdit();
            baru = false;
            kodeLama = tbKode.Text;
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            baru = true;
            tbAlamat.Text = "";
            tbKode.Text = "";
            tbKota.Text = "";
            tbnamaSupplier.Text = "";
            tbTelepon.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            String com, kode, nama, alamat, kota, telp;
            kode = tbKode.Text;
            nama = tbnamaSupplier.Text;
            alamat = tbAlamat.Text;
            kota = tbKota.Text;
            telp = tbTelepon.Text;

            if (baru)
            {
                com = "insert into supplier values('{0}','{1}','{2}','{3}','{4}')";
                com = String.Format(com, kode, nama, alamat, kota, telp);
            }
            else
            {
                com = "update supplier set kodeSupplier='{0}', namaSupplier='{1}', alamat='{2}', kota='{3}', telpon='{4}'";
                com += "where kodeSupplier='{5}'";
                com = String.Format(com, kode, nama, alamat, kota, telp, getkodeLama());
            }
            supplier.eksekusiSQL(com);
            modeSave();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM supplier WHERE kodeSupplier='{0}'";
                stringSQL = string.Format(stringSQL, tbKode.Text);
                MessageBox.Show("Periksa dulu : " + stringSQL);
                this.supplier.eksekusiSQL(stringSQL);
                MessageBox.Show("Penghapusan selesai dilaksanakan..."); //<-- feedback
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan..."); //<-- feedback
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            FormCariSupplier cari = new FormCariSupplier();
            cari.ShowDialog();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FormLapSupplier lihat = new FormLapSupplier();
            lihat.ShowDialog();
            lihat.Dispose();
        }
    }
}
