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
    public partial class FormManipulasiUser : Form
    {
        public FormManipulasiUser()
        {
            InitializeComponent();
        }
        bool baru = true;
        Tabel inputuser = new Tabel("Pemakai");

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //28 Nov 2016
            //TERAKHIR SAMPE SINI. INPUT USER BARU TAPI GA MASUK DI DATABASE. CEK LAGI YA :)
            String user, pass1, pass2;
            String setBar, setSup, jual, beli, lapStok, lapSup, lapBeli, lapJual, formUser;
            user = txtUsername.Text;
            pass1 = txtPassword.Text;
            pass2 = txtConfirm.Text;
            if (pass1 != pass2)
            {
                MessageBox.Show("Password salah coba lagi");
                txtConfirm.Clear();
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
            setBar = cbSetBar.Checked.ToString();
            setSup = cbSetSup.Checked.ToString();
            jual = cbTransaksiJual.Checked.ToString();
            beli = cbTransaksiBeli.Checked.ToString();
            lapStok = false.ToString();
            lapSup = false.ToString();
            lapBeli = cbLapBeli.Checked.ToString();
            lapJual = cbLapJual.Checked.ToString();
            formUser = cbSetBar.Checked.ToString();
            String strsql;
            if (this.baru)
            {
                MessageBox.Show("setbar = " + setBar + "\nsetSup = " + setSup + "\njual = " + jual + "\nbeli = " + beli +
                    "\nlapBeli = " + lapBeli + "\nlapjual = " + lapJual + "\nformuser = " + formUser);
                strsql = "insert into pemakai(username, password, setupBarang, setupSupplier, jual, beli, lapstok, lapsupplier" +
                    ", lapBeli, lapJual, formuser) " + "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";
                strsql = String.Format(strsql, user, pass1, setBar, setSup, jual, beli, lapStok, lapSup, lapBeli, lapJual, formUser);
                inputuser.eksekusiSQL(strsql);
                MessageBox.Show("Sukses");
                modeSave();
            }
        }

        private void FormManipulasiUser_Load(object sender, EventArgs e)
        {

            //txtConfirm.Visible= false;
            //txtPassword.Enabled = false;
            //txtUsername.Enabled = false;
            modeSave();
            txtUsername.DataBindings.Add("text", inputuser.getBs(), "userName");
            //MessageBox.Show(txtUsername.DataBindings.Add("text", inputuser.getBs(), "userName").ToString());
            txtPassword.DataBindings.Add("text", inputuser.getBs(), "password");
            txtUsername.Text = txtPassword.Text;
            cbLapBeli.DataBindings.Add("checked", inputuser.getBs(), "labBeli");
            cbLapJual.DataBindings.Add("checked", inputuser.getBs(), "lapJual");
            cbSetBar.DataBindings.Add("checked", inputuser.getBs(), "setupbarang");
            cbSetSup.DataBindings.Add("checked", inputuser.getBs(), "setupsupplier");
            cbTransaksiBeli.DataBindings.Add("checked", inputuser.getBs(), "beli");
            cbTransaksiJual.DataBindings.Add("checked", inputuser.getBs(), "jual");
            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            baru = true;
            txtConfirm.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            groupBox1.Enabled = true;
            modeEdit();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modeEdit()
        {
            txtConfirm.Visible = true;
            txtConfirm.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            BtnTop.Enabled = false;
            BtnBack.Enabled = false;
            BtnNext.Enabled = false;
            BtnEnd.Enabled = false;
            //BtnPrint.Enabled = false;
            BtnFind.Enabled = false;
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Visible = true; //<-- visible-nya
            BtnUndo.Visible = true; //<-- visible-nya
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            BtnDel.Enabled = false;
            BtnClose.Enabled = false;
            
        }

        private void modeSave()
        {
            txtConfirm.Visible = false;
            txtConfirm.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            BtnTop.Enabled = true;
            BtnBack.Enabled = true;
            BtnNext.Enabled = true;
            BtnEnd.Enabled = true;
            //BtnPrint.Enabled = true;
            BtnFind.Enabled = true;
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSave.Visible = false; //<-- visible-nya
            BtnUndo.Visible = false; //<-- visible-nya
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            BtnDel.Enabled = true;
            BtnClose.Enabled = true;
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            inputuser.getBs().MoveFirst();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            inputuser.getBs().MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            inputuser.getBs().MoveNext();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            inputuser.getBs().MoveLast();
        }
    }
}
