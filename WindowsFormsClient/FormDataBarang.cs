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
    public partial class FormDataBarang : Form
    {
        public FormDataBarang()
        {
            InitializeComponent();
        }
        private bool baru;
        private string kodeLama;
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();

        private void FormBindingSource_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            da.Dispose();
            con.Close();

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            TxtkodeBarang.DataBindings.Add("Text", bs, "kodeBarang");
            TxtnamaBarang.DataBindings.Add("Text", bs, "namaBarang");
            TxthargaBeli.DataBindings.Add("Text", bs, "hargaBeli");
            TxthargaJual.DataBindings.Add("Text", bs, "hargaJual");
            Txtstok.DataBindings.Add("Text", bs, "stok");
            Cmbsatuan.DataBindings.Add("Text", bs, "satuan");

            DgvBarang.DataSource = bs;
       }
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
            BtnSave.Visible = true; //<-- Visible
            BtnUndo.Visible = true; //<-- Visible
            BtnDel.Enabled = false;
            BtnClose.Enabled = false;

            TxtkodeBarang.Focus();
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
            BtnSave.Visible = false; //<-- Visible
            BtnUndo.Visible = false; //<-- Visible
            BtnDel.Enabled = true;
            BtnClose.Enabled = true;
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
            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            TxtkodeBarang.Text = "";
            TxtnamaBarang.Text = "";
            TxthargaBeli.Text = "0";
            TxthargaJual.Text = "0";
            Txtstok.Text = "0";
            Cmbsatuan.Text = "Exemplar"; //<- default value
            this.baru = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
            this.baru = false;
            this.kodeLama = TxtkodeBarang.Text;
        }
        private void kirimSQL(string stringSQL)
        {
            try
            {
                SqlConnection con = new
                SqlConnection("Data source=.\\SQLEXPRESS;Initial catalog=inventory;Integrated security=true");
                con.Open();

                SqlCommand cmd = new SqlCommand(stringSQL, con);
                cmd.ExecuteNonQuery(); //<-- mengeksekusi Query tanpa mendapat nilai kembalian

                //isi ulang DataTable:
                dt.Clear(); //<-- kalau tidahapus yang lama akan disambung
                cmd = new SqlCommand("SELECT * FROM barang", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt); //<-- data yang baru (y)
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            {//INSERT
                stringSQL = "INSERT INTO barang VALUES('{0}', '{1}', ";
                stringSQL += "'{2}', '{3}', '{4}', '{5}')";
                stringSQL = String.Format(stringSQL, kode, nama, beli,
                    jual, stok, satuan);
            }
            else
            {//UPDATE
                stringSQL = "UPDATE barang SET kodeBarang='{0}', namaBarang='{1}', ";
                stringSQL += "hargaBeli='{2}', hargaJual='{3}', stok='{4}', satuan='{5}' ";
                stringSQL += "WHERE kodeBarang='{6}'";
                stringSQL = String.Format(stringSQL, kode, nama, beli,
                    jual, stok, satuan, this.kodeLama);
            }
            modeSave();
            MessageBox.Show(stringSQL); //<-- Uji Coba, apakah penulisan SQL sudah benar
            kirimSQL(stringSQL);
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jwb;
            jwb = MessageBox.Show("Apakah yakin dihapus?", "Konfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == System.Windows.Forms.DialogResult.Yes)
            {
                String strSql="DELETE FROM barang WHERE kodeBarang='{0}'";
                strSql = string.Format(strSql,TxtkodeBarang.Text);
                kirimSQL(strSql);
                MessageBox.Show("Penghapusan selesai..."); //<-- feedback
            }
            else
            {
                MessageBox.Show("Penghapusan batal..."); //<-- feedback
            }
        }
    }
}
