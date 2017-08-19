using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connectionString = 
            //"Data Source=.\\SQLEXPRESS;Initial Catalog=inventory;integrated security = true";
            //SqlConnection con = new SqlConnection(connectionString);
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            MessageBox.Show(strCon.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBarang.DataSource = dt;
        }
    }
}

