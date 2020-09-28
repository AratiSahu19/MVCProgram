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
    public partial class Dashboard : System.Web.UI.Page
    {
        static string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "<b><font color=Brown>" + "WELCOME:: " + "</font>" + "<b><font color=red>" + Session["Email_Id"] + "</font>";
            con.Open();
            string qr = "select firstname,lastname from registrationtb where email='" + Session["email"] + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Label2.Text = dr["firstname"].ToString();
                Label3.Text = dr["lastname"].ToString();
            }
            dr.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["email"] = "";
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

        }
    }
}