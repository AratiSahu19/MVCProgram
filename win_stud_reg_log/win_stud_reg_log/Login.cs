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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string strcon = "data source=.\\sqlexpress;integrated security=true;database=Student1_Db";
            SqlConnection con = new SqlConnection(strcon);
            string em = textBox1.Text;
            string pass = textBox2.Text;
          
                con.Open();
                string qr = "select count(*) from stud_table where Email_Id='" + em + "' and password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qr, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if(i==1)
                {
                    studform sf = new studform();
                    this.Visible = false;
                    sf.Show();
                }
                else
                {
                    label4.Text = "invalid credential";
                }
            
            
           

            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
