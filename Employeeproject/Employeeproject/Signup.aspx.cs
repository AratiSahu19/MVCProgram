using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Employeeproject
{
    public partial class Signup : System.Web.UI.Page
    {
        static string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fname = TextBox1.Text;
            string lname = TextBox2.Text;
            string gender = "";
            if (RadioButton1.Checked)
            {
                gender = RadioButton1.Text;
                RadioButton2.Visible = false;

            }
            else if (RadioButton2.Checked)
            {
                gender = RadioButton2.Text;
                RadioButton1.Visible = false;

            }
            string dob = TextBox3.Text;
            string age = TextBox4.Text;
            string doj = TextBox5.Text;
            string desig = TextBox6.Text;
            string email = TextBox7.Text;
            string pass = common.Encryptdata(TextBox8.Text);
            string c_pass = TextBox9.Text;
            string status = "";
            if (CheckBox1.Checked)
            {
                status = "Active";

            }
            else
            {
                status = "Deactive";
            }
            try
            {
                con.Open();
                string qr = "select count(*) from Emp_Table where Email_Id='" + email + "'";
                SqlCommand cmd = new SqlCommand(qr, con);
                //string result = "";
                int res = Convert.ToInt32(cmd.ExecuteScalar());
                if (res == 1)
                {
                    Label1.Text = "Email already exist";
                }
                else
                {
                    try
                    {

                        string qr1 = "insert into Emp_Table values('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + desig + "','" + email + "','" + pass + "','" + status + "')";
                        SqlCommand cmd1 = new SqlCommand(qr1, con);
                        cmd1.ExecuteNonQuery();
                        Label1.Text = "Registration successful";
                    }
                    catch (Exception ee)
                    {
                        Label1.Text = ee.ToString();
                    }
                }
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            CheckBox1.Text = "";
            RadioButton1.Text = "";
            RadioButton2.Text = "";
               
        }
       

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            common obj = new common();
            DateTime dob = Convert.ToDateTime(TextBox3.Text);
            TextBox4.Text = Convert.ToString(common.calculate_age(dob));
        }
    }
}
  