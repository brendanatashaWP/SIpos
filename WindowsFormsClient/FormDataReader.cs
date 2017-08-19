using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormDataReader : Form
    {
        public FormDataReader()
        {
            InitializeComponent();
        }

        private void FormDataReader_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                rtbBarang.Text +="Field tabel barang : " + dr.FieldCount + " buah\n\n";
                while (dr.Read())
                {
                    rtbBarang.Text += dr.GetValue(0) + "\t" + dr.GetValue(1) + "\n";
                }
            }
            else
                rtbBarang.Text = "No rows found.";
            dr.Close();
            con.Close();
        }
    }
}
