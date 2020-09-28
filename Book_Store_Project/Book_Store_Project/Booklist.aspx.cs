using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Book_Store_Project
{
    public partial class Booklist : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {




            string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string qr = "select Id,Bookname,MRP,Author,Category,Publisher from bookentrytb";
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "bookentrytb");
            Response.Write("<h1 align=center >Details of Book  </h1><hr>");
            Response.Write("<table width=100% border=1 align=center>");
            Response.Write("<tr>");

            Response.Write("<th>Id </th>");
            Response.Write("<th>Book Name </th>");
            Response.Write("<th>MRP </th>");
            Response.Write("<th> Author </th>");
            Response.Write("<th>Category </th>");
            Response.Write("<th>Publisher </th>");




            Response.Write("</tr>");
            foreach (DataRow dr in ds.Tables["bookentrytb"].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["Id"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["BookName"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["MRP"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["Author"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["Category"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["Publisher"].ToString());
                Response.Write("</td>");


                Response.Write("<\tr>");
            }
            Response.Write("</table>");

        }
        
    }
    
}