using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public class Tabel
    {
        private String namaTabel;
        private DataTable dt;
        private BindingSource bs;

        public Tabel(String namaTabel)
        {
            this.namaTabel = namaTabel;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            this.isiDataTable();
            this.bs.DataSource = this.dt;
        }

        private void isiDataTable()
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\sqlexpress";
            strCon.InitialCatalog = "inventorytugas";
            strCon.IntegratedSecurity = true;
            //strCon.UserID = "Komputer Server";
            //strCon.Password = "rahasia";
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + this.namaTabel, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            
            this.dt.Clear(); //kosongkan dulu
            da.Fill(this.dt);
            con.Close();
        }

        public void isiDataTable(String strsql)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\sqlexpress";
            strCon.InitialCatalog = "inventorytugas";
            strCon.IntegratedSecurity = true;
            //strCon.UserID = "Komputer Server";
            //strCon.Password = "rahasia";
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(strsql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            this.dt.Clear(); //kosongkan dulu
            da.Fill(this.dt);
            con.Close();
        }

        public DataTable getDT()
        {
            return this.dt;
        }

        public void eksekusiSQL(String stringSQL)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\sqlexpress";
            strCon.InitialCatalog = "inventorytugas";
            strCon.IntegratedSecurity = true;
            //strCon.UserID = "Komputer Server";
            //strCon.Password = "rahasia";
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(stringSQL, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.isiDataTable();
        }

        public BindingSource getBs()
        {
            return this.bs;
        }

        public String eksekusiSQL_getID(String stringSQL)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "inventorytugas";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(stringSQL, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select @@identity", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String idNya = dr.GetValue(0).ToString();
            con.Close();
            this.isiDataTable();
            return idNya;
        }


    }
}
