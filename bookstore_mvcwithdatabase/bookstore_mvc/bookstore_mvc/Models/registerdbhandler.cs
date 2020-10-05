using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace bookstore_mvc.Models
{
    public class registerdbhandler
    {

        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["conbook"].ToString();
            con = new SqlConnection(constring);

        }

        public bool Insert(Registermodel iList)
        {
            connection();

            string qr = "insert into registrationtb values('" + iList.firstname + "','" + iList.lastname + "','" + iList.gender + "','" + iList.dob + "','" + iList.age + "','" + iList.email + "','" + iList.password + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
                return false;
        }

    }
}
