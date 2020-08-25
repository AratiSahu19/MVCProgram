using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace New_SPS_project
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {
        string email = TextBox2.Text;
        string pass = TextBox1.Text;
        user_management.login l1 = new user_management.login();
        string r = l1.checklogin(email, pass);
         
        Label3.Text = r;
            Response.Write(r); 
        
        if (r == "admin" )
        {
            Session["email_id"] = email; 
            Response.Redirect("admindashboard.aspx");

         
        }
        else if (r == "Student")
        {
            Session["email_id"] = email; 
            Response.Redirect("studentdashboard.aspx");

            
        }
        else if (r == "Teacher")
        {
            Session["email_id"] = email; 
            Response.Redirect("facultydashboard.aspx");

           
        }
        else if(r=="false")
        {

            Label3.Text = "invalid credentials , try again";
        }
        else
        {
            Label3.Text = r;
        }

    }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
    }
