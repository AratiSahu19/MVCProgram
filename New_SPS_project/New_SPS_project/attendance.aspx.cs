using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace New_SPS_project
{
    public partial class attendance : System.Web.UI.Page
    {

        string first_name;
        string last_name;
        string course;
       string attendance1;
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) // marks attendance button
        {

            SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database");
            cn.Open();
            //string firstname = TextBox2.Text;
            //string lastname = TextBox3.Text;
            string course1 = DropDownList2.SelectedValue;
            Response.Write(course1);

            string qr = "select first_name,last_name,course from Register_db where role = 'Student' and course = '" + DropDownList2.Text + "' ";
            //         
            SqlCommand cmd = new SqlCommand(qr, cn);
            cmd.ExecuteNonQuery();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(qr, cn);
            da.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            cn.Close();
        }
        private void saveattendance(string first_name,string last_name,string course,string attendance,string date)
        {

            SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database");

            cn.Open();

            string insertQry = "INSERT INTO student_attendance(first_name, last_name,course,attendance) " +
                               "VALUES(' " + first_name + "', ' " + last_name + "', ' " + course + " ',' " + attendance + " ',' " 
                               +date+" '";



            SqlCommand cmd = new SqlCommand(insertQry, cn);

            cmd.ExecuteNonQuery();


            cn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)

        {
            for (int i= 0;i < GridView1.Rows.Count;i++)
            
            {

                first_name = GridView1.Rows[i].Cells[1].Text;
                last_name = GridView1.Rows[i].Cells[1].Text;
                course = GridView1.Rows[i].Cells[1].Text;
                RadioButton rb1 = (GridView1.Rows[i].Cells[1].FindControl("RadioButton1") as RadioButton);
                RadioButton rb2 = (GridView1.Rows[i].Cells[1].FindControl("RadioButton2") as RadioButton);

                if (rb1.Checked)
                {
                    attendance1 = "Present";
                }
                else if(rb2.Checked)
                {
                    attendance1 = "Absent";
                }
                else
                {
                    Label2.Text = "Please choose one option";
                }
                date = DateTime.Now.ToShortDateString();
                saveattendance(first_name, last_name, course, attendance1,date);

            }
}
          

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

     
            //SqlConnection cn = new SqlConnection("data source = DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database = student_database");
            //cn.Open();
            //string firstname = TextBox2.Text;
            //string lastname = TextBox3.Text;
            //string course = DropDownList2.SelectedValue;

            //string qr= "insert into student_entry(first_name,last_name,course) values('"+firstname+"','"+lastname+"','"+course +"')";
            //SqlCommand cmd = new SqlCommand(qr,cn);
            //cmd.ExecuteNonQuery();

            //cn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            Label1.Text = string.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(TextBox1.Text));
          

        }
    }
}