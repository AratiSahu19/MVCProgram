using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace win_stud_reg_log
{
    public partial class Form1 : Form
    {
        static string strcon = "data source=.\\sqlexpress;integrated security=true;database=Student1_Db";
        SqlConnection con = new SqlConnection(strcon);
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nm = textBox1.Text;
            string cl = textBox2.Text;
            string email = textBox3.Text;
            string pass = textBox4.Text;
         
            con.Open();
            string qr = "insert into stud_Table values('" + nm + "','" + cl + "','" + email + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            if(i>=1)
            {
                label6.Text = "student registered successfully";
            }
            else
            {
                label6.Text = "not registered";
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Visible = false;
            lg.Show();

        }
           
    }
}
