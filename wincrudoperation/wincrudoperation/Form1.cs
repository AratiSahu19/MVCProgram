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
namespace wincrudoperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=practicedb;Integrated Security=True;database=practicedb");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pname = textBox2.Text;
                string cat = textBox3.Text;
                string qr=" Update products set category='"+cat+"' where Id = '"+pid+"'";
                SqlCommand com = new SqlCommand(qr, con);
                com.ExecuteNonQuery();
                label4.Text = "Record Updated";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch(Exception ee)
            {
                label4.Text = ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pname = textBox2.Text;
                string cat = textBox3.Text;
                string qr = "insert into products values (" + pid + ",'" + pname + "','" + cat + "')";
                SqlCommand com = new SqlCommand(qr, con);
                com.ExecuteNonQuery();
                label4.Text = "Record Saved";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pname = textBox2.Text;
                string cat = textBox3.Text;
                string qr = "delete from products where Id="+pid+"";
                SqlCommand com = new SqlCommand(qr, con);
                com.ExecuteNonQuery();
                label4.Text = "Record deleted";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pn = textBox2.Text;
                string cat = textBox3.Text;
                string qr = "select * from products where  Id="+ pid + "";
                SqlCommand command = new SqlCommand(qr, con);
                SqlDataReader dr = command.ExecuteReader();
                int flag = 0;
                while (dr.Read())
                {
                    flag = 1;
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                }
                if (flag == 0)
                    label4.Text = "no record exist ";


            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }



        }
    }
}
