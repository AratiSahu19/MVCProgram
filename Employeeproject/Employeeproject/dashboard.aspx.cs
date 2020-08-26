using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Employeeproject
{
    public partial class dashboard : System.Web.UI.Page
    {
         static string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "<b><font color=Brown>" + "WELCOME:: " + "</font>" + "<b><font color=red>" + Session["Email_Id"] + "</font>";
            con.Open();
            string qr="select First_Name,Last_Name from Emp_Table where Email_Id='"+Session["Email_Id"]+"'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Label2.Text = dr["First_Name"].ToString();
                Label3.Text = dr["Last_Name"].ToString();
            }
            dr.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Email_id"] = "";
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("home.aspx");
        }
    }
}