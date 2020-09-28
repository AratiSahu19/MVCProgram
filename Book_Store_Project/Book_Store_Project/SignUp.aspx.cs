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
    public partial class SignUp : System.Web.UI.Page
    {
        static string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            string lname = txtlname.Text;
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
            string dob = txtdob.Text;
            string age = txtage.Text;

            string email = txtemail.Text;
            string pass = Common.Encryptdata(txtpasword.Text);
            string c_pass = txtcpasword.Text;


            try
            {
                con.Open();
                string qr = "select count(*) from registrationtb where email='" + email + "'";
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

                        string qr1 = "insert into registrationtb values('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + age + "','" + email + "','" + pass + "')";
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
            txtfname.Text = "";
            txtlname.Text = "";
            txtdob.Text = "";
            txtage.Text = "";
            txtemail.Text = "";
            txtpasword.Text = "";
            txtcpasword.Text = "";

            RadioButton1.Text = "";
            RadioButton2.Text = "";

        }

        protected void txtdob_TextChanged(object sender, EventArgs e)
        {
            Common obj = new Common();
            DateTime dob = Convert.ToDateTime(txtdob.Text);
            txtage.Text = Convert.ToString(Common.calculate_age(dob));
        }

       
    }
}