using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace bookstore_mvc.Models
{
    public class BookstoredbHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["conbook"].ToString();
            con = new SqlConnection(constring);

        }

        public bool InsertBook(Bookstoremodel iList)
        {
            connection();

            string qr = "insert into bookentrytb values('" + iList.BookName + "','" + iList.MRP + "','" + iList.Author + "','" + iList.Category + "','" + iList.Publisher + "')";
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

        public List<Bookstoremodel> GetBookList()
        {
            connection();
            List<Bookstoremodel> iList = new List<Bookstoremodel>();

            string query = "Select Id,BookName,MRP,Author,Category,Publisher from bookentrytb";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new Bookstoremodel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    BookName = Convert.ToString(dr["BookName"]),
                    MRP = Convert.ToString(dr["MRP"]),
                    Authors = Convert.ToString(dr["Author"]),
                    Categorys = Convert.ToString(dr["Category"]),
                    Publishers = Convert.ToString(dr["Publisher"])
                });
            }
            return iList;
        }

        public bool UpdateBook(Bookstoremodel iList)
        {
            connection();
            string query = "Update bookentrytb set BookName = '" + iList.BookName + "', MRP = '" + iList.MRP+ "', Author = '" + iList.Author + "', Category = '" + iList.Category + "', Publisher = " + iList.Publisher + " where Id = " + iList.Id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
        public bool DeleteBook(int Id)
        {
            connection();
            string query = "delete from bookentrytb where Id = " + Id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }



    }
}