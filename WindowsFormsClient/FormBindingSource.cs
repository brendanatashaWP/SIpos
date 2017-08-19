using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormBindingSource : Form
    {
        public FormBindingSource()
        {
            InitializeComponent();
        }
        private bool baru;
        private string kodeLama;
        private DataTable dt = new DataTable();
        private BindingSource bs = new BindingSource();

        private void modeEdit()
        {
            TxtkodeBarang.Enabled = true;
            TxtnamaBarang.Enabled = true;
            TxthargaBeli.Enabled = true;
            TxthargaJual.Enabled = true;
            Txtstok.Enabled = true;
            Cmbsatuan.Enabled = true;
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
            BtnDel.Enabled = false;
            BtnClose.Enabled = false;
            TxtkodeBarang.Focus();
            lepas();
        }

        private void modeSave()
        {
            TxtkodeBarang.Enabled = false;
            TxtnamaBarang.Enabled = false;
            TxthargaBeli.Enabled = false;
            TxthargaJual.Enabled = false;
            Txtstok.Enabled = false;
            Cmbsatuan.Enabled = false;
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
            BtnDel.Enabled = true;
            BtnClose.Enabled = true;
            ikat();
        }

        private void ikat()
        {
            TxtkodeBarang.DataBindings.Add("Text", bs, "kodeBarang");
            TxtnamaBarang.DataBindings.Add("Text", bs, "namaBarang");
            TxthargaBeli.DataBindings.Add("Text", bs, "hargaBeli");
            TxthargaJual.DataBindings.Add("Text", bs, "hargaJual");
            Txtstok.DataBindings.Add("Text", bs, "stok");
            Cmbsatuan.DataBindings.Add("Text", bs, "satuan");
        }

        private void lepas()
        {
            TxtkodeBarang.DataBindings.Clear();
            TxtnamaBarang.DataBindings.Clear();
            TxthargaBeli.DataBindings.Clear();
            TxthargaJual.DataBindings.Clear();
            Txtstok.DataBindings.Clear();
            Cmbsatuan.DataBindings.Clear();
        }

        private void kirimSQL(String strSQL)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT * FROM barang", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear(); //<-- kosongkan dulu DataTable
            da.Fill(dt);
            con.Close();
        }

        private void FormBindingSource_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            da.Dispose();
            con.Close();

            bs.DataSource = dt;
            TxtkodeBarang.DataBindings.Add("Text", bs, "kodeBarang");
            TxtnamaBarang.DataBindings.Add("Text", bs, "namaBarang");
            TxthargaBeli.DataBindings.Add("Text", bs, "hargaBeli");
            TxthargaJual.DataBindings.Add("Text", bs, "hargaJual");
            Txtstok.DataBindings.Add("Text", bs, "stok");
            Cmbsatuan.DataBindings.Add("Text", bs, "satuan");
            DgvBarang.DataSource = bs;
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            String kode, nama, beli, jual, stok, satuan;
            kode = TxtkodeBarang.Text;
            nama = TxtnamaBarang.Text;
            beli = TxthargaBeli.Text;
            jual = TxthargaJual.Text;
            stok = Txtstok.Text;
            satuan = Cmbsatuan.Text;

            String insert;
            insert="INSERT INTO barang VALUES('{0}','{1}','{2}','{3}','{4}','{5}')";
            insert = String.Format(insert, kode, nama, beli, jual, stok, satuan);

            MessageBox.Show(insert);
            modeSave();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            TxtkodeBarang.Text = "";
            TxtnamaBarang.Text = "";
            TxthargaBeli.Text = "0";
            TxthargaJual.Text = "0";
            Txtstok.Text = "0";
            Cmbsatuan.Text = "Exemplar";
            this.baru = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
            this.baru = false;
            this.kodeLama = TxtkodeBarang.Text; //<-- catat dulu sebelum diubah
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string stringSQL, kode, nama, beli, jual, stok, satuan;
            kode = TxtkodeBarang.Text;
            nama = TxtnamaBarang.Text;
            beli = TxthargaBeli.Text;
            jual = TxthargaJual.Text;
            stok = Txtstok.Text;
            satuan = Cmbsatuan.Text;
            if (baru)
            {
                stringSQL = "INSERT INTO barang VALUES('{0}','{1}','{2}','{3}',";
                stringSQL += "'{4}','{5}')";
                stringSQL = String.Format(stringSQL, kode, nama, beli, jual, 
                    stok, satuan);
            }
            else
            {
                stringSQL = "UPDATE barang SET kodeBarang='{0}', namaBarang='{1}', ";
                stringSQL += "hargaBeli='{2}', hargaJual='{3}', stok='{4}', ";
                stringSQL += "satuan='{5}' WHERE kodeBarang='{6}')";
                stringSQL = String.Format(stringSQL, kode, nama, beli, jual, stok, 
                    satuan, this.kodeLama);
            }
            MessageBox.Show("Periksa dulu : " + stringSQL);
            kirimSQL(stringSQL);
            modeSave();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM barang WHERE kodeBarang='{0}'";
                stringSQL = string.Format(stringSQL, TxtkodeBarang.Text);
                MessageBox.Show("Periksa dulu : " + stringSQL);
                kirimSQL(stringSQL);
                MessageBox.Show("Penghapusan selesai dilaksanakan..."); //<-- feedback
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan..."); //<-- feedback
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }
    }
}
