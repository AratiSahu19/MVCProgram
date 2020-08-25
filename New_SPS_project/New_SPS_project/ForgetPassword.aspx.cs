using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
namespace New_SPS_project
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string pass1 = TextBox1.Text; ;
            string conpass=TextBox2.Text;
            string qr1;
            string em=TextBox3.Text;
            SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database");
            cn.Open();
           
          
            qr1 = " update Register_db set password= ' "+pass1+"',confirm_pwd=' " +conpass+" ' where email_id = ' " + em + " ' ";
            SqlCommand cmd = new SqlCommand(qr1,cn);
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            lbltxt.Text = "Password Successfully Updated";
        }
    }
}