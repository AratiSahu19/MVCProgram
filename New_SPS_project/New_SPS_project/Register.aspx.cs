using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using user_management;
using System.Data.SqlClient;
namespace New_SPS_project
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fn = TextBox1.Text;
            string ln = TextBox2.Text;
            string dob = TextBox9.Text;
            string pn = TextBox4.Text;
            string add = TextBox5.Text;
            string c = DropDownList1.Text;
            string g = "";
            if (RadioButton1.Checked)
            {
                g = RadioButton1.Text;
                RadioButton2.Visible = false;
            }
            else if (RadioButton2.Checked)
            {
                g = RadioButton2.Text;
                RadioButton1.Visible = false;
            }

            string r = "";
            if (RadioButton3.Checked)
            {
                r = RadioButton3.Text;
                RadioButton4.Visible = false;

            }
            else if (RadioButton4.Checked)
            {
                r = RadioButton4.Text;
                RadioButton3.Visible = false;
            }
            string em = TextBox6.Text;
            string p = TextBox7.Text;
            string cp = TextBox8.Text;

            Registration reg = new Registration();
            string res = reg.saveregistration(fn, ln, dob, pn, add, g, c, r, em, p, cp);
            Label13.Text = res;

            TextBox1.Focus();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Response.Redirect("Login.aspx");
        }

      

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}