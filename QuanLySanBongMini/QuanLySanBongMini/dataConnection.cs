using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows.Markup;
namespace QuanLySanBongMini
{
    internal class dataConnection
    {
        SqlConnection con = new SqlConnection("Data Source=Laptop-a5ciml19;Initial Catalog=QLSanBongDaMini;Integrated Security=True;Encrypt=False");

        public void openCon()
        {
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public Boolean Exe(string cmd)
        {
            openCon();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }catch (Exception ex)
            {
                check = false;
            }
            closeCon();
            return check;
        }

    
        public DataTable TruyVan(string cmd)
        {
            openCon();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }catch (Exception ex)
            {
                dt = null;
            }
            closeCon();
            return dt;
        }
        
    }
}
