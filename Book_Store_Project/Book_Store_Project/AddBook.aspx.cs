using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Book_Store_Project
{
    public partial class AddBook : System.Web.UI.Page
    {
        static string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string bname = txtbname.Text;
            string mrp = txtmrp.Text;
            string author = DropDownList1.Text;
            string category = DropDownList2.Text;
            string publisher = DropDownList3.Text;
            try
            {
                con.Open();
                string qr1 = "insert into bookentrytb values('" + bname + "','" + mrp + "','" + author + "','" + category + "','" + publisher + "')";
                SqlCommand cmd1 = new SqlCommand(qr1, con);
                cmd1.ExecuteNonQuery();
                Label1.Text = "Book Added successfully";
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
                {
                con.Close();
            }
        }
    }
}