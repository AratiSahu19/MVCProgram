﻿using System;
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
    public partial class Login : System.Web.UI.Page
    {
        static string strcon = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = TextBox1.Text;
            string pass = Common.Encryptdata(TextBox2.Text);
            try
            {
                con.Open();
                string qr = "select count(*) from registrationtb where email='" + em + "' and password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qr, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i == 1)
                {
                    Session["Email_Id"] = em;
                    Response.Redirect("dashboard.aspx");

                }
                else
                {
                    Label1.Text = "invalid credential";
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

        }
    }
}
    
