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
    public partial class FormUser : Form
    {
        Tabel pemakai = new Tabel("Pemakai");

        public FormUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private String user, pass;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = txtUsername.Text;
            pass = txtPassword.Text;
            getnamaUser();
            this.pemakai.getBs().Filter = "userName='" + user + "'";
            int ada = pemakai.getBs().Find("password", pass);
            if (ada >= 0)
            {
                pemakai.getBs().Position = ada;
                MessageBox.Show("Selamat datang " + user);
                bool setBar, setSup, jual, beli, lapStok, lapSup, lapBeli, lapJual, formUser;
                setBar = (bool)((DataRowView)pemakai.getBs().Current).Row["setupbarang"];
                setSup = (bool)((DataRowView)pemakai.getBs().Current).Row["setupSupplier"];
                jual = (bool)((DataRowView)pemakai.getBs().Current).Row["jual"];
                beli = (bool)((DataRowView)pemakai.getBs().Current).Row["beli"];
                lapStok = (bool)((DataRowView)pemakai.getBs().Current).Row["lapStok"];
                lapSup = (bool)((DataRowView)pemakai.getBs().Current).Row["lapSupplier"];
                lapBeli = (bool)((DataRowView)pemakai.getBs().Current).Row["lapBeli"];
                lapJual = (bool)((DataRowView)pemakai.getBs().Current).Row["lapJual"];
                formUser = (bool)((DataRowView)pemakai.getBs().Current).Row["formuser"];
                //MessageBox.Show("Hasil : " + setBar+ setSup+ jual+ beli+ lapStok+ lapSup+ lapBeli+ lapJual+ formUser);
                FormUtama tampil = new FormUtama(setBar, setSup, jual, beli, lapStok, lapSup, lapBeli, lapJual, formUser, getnamaUser().ToString());
                tampil.ShowDialog();
                tampil.Dispose();
                txtPassword.Clear();
                txtUsername.Clear();
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Access Denied..");
            }
        }

       
        
        public String getnamaUser()
        {
            String nama = txtUsername.Text;
            //MessageBox.Show(nama);
            return nama;
        }

        // getnamauser buat kasih nama user yang sedang login di pojok kiri atas, sebelah nama namespacenya
    }
}
