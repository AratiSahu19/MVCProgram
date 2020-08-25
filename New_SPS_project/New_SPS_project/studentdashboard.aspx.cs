using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace New_SPS_project
{
    public partial class studentdashboard : System.Web.UI.Page
    {
        string query;
        string course;
        string em;
        //string first_name;
        //string last_name;
        string label;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            
            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                //em = Session["email_id"].ToString();
                
                //Label3.Text = em;
                string qr1 = "select course from Register_db where email_id='" + em + "' ";
                SqlCommand command1 = new SqlCommand(qr1, cn);
                course = Convert.ToString(command1.ExecuteScalar());
                //Response.Write(course);

               
                
                Label4.Text ="Welcome"+"    "+ em +"Enroll for"+"    "+ course +"";
                cn.Close();

            }
            // This code is to show the username on label after log in through his/her email_id
            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                em = Session["email_id"].ToString();

                //Label3.Text = em;
                string qr1 = "select first_name,last_name from Register_db where email_id='" + em + "' ";
                SqlCommand command1 = new SqlCommand(qr1, cn);

                SqlDataReader dr = command1.ExecuteReader();
                
                while (dr.Read())
                {
                    
                    Response.Write(dr["first_name"].ToString() + " ");
                    Response.Write(dr["last_name"].ToString() + " ");
                    label=dr.IsDBNull(dr.GetOrdinal("first_name")) ? String.Empty : dr.GetString(dr.GetOrdinal("first_name"));
                   
                }
                dr.Close();
                Label4.Text = "Welcome" +"     "+ label;
                

               // Label4.Text = "Welcome" + "    " + first_name + last_name + "Enroll for" + "    " + course + "";
               
                cn.Close();

            }

        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            Session["email_id"] = "";
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Homepage.aspx");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            //View Assignment Button
            //Select assignment from assignment table and display on gridview.

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                string commandText = "select a.filename,date from  Assignment_DB as a left outer join Register_db as r on a.course=r.course where email_id= '"+em+"' ";
                // string commandText = "select * from Register_db";
                cmd.CommandText = commandText;
                //  cmd.CommandType = System.Data.CommandType.Text;
               

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(commandText, cn);
                da.Fill(ds);

                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                cn.Close();
                }

            }



     //   }
   

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Upload button coding
            //Upload file to the database

            Label2.Visible = true;

            string filePath = FileUpload1.PostedFile.FileName;          // getting the file path of uploaded file

            string filename1 = Path.GetFileName(filePath);               // getting the file name of uploaded file

            string ext = Path.GetExtension(filename1);                      // getting the file extension of uploaded file

            string type = String.Empty;

            string date = TextBox2.Text;

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                if (!FileUpload1.HasFile)

                {

                    Label2.Text = "Please Select File";                          //if file uploader has no file selected

                }

                else

                   if (FileUpload1.HasFile)

                {

                    try

                    {


                        switch (ext)                                         // this switch code validate the files which allow to upload only PDF  file 

                        {

                            case ".doc":

                                type = "application/word";

                                break;

                            case ".docx":

                                type = "application/word";

                                break;



                        }


                        if (type != String.Empty)

                        {


                            Stream fs = FileUpload1.PostedFile.InputStream;

                            BinaryReader br = new BinaryReader(fs);                                 //reads the   binary files

                            Byte[] bytes = br.ReadBytes((Int32)fs.Length);                           //counting the file length into bytes

                            query = "insert into Assignment_Submission (filename,type,data,date)" + " values (@filename, @type, @Data,@Date)";   //insert query

                            cmd = new SqlCommand(query, cn);

                            cmd.Parameters.Add("@filename", SqlDbType.VarChar).Value = filename1;

                            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;


                            cmd.Parameters.Add("@data", SqlDbType.Binary).Value = bytes;

                            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;

                            cmd.ExecuteNonQuery();

                            Label2.ForeColor = System.Drawing.Color.Green;

                            Label2.Text = " Word File Uploaded Successfully";



                        }

                        else

                        {

                            Label2.ForeColor = System.Drawing.Color.Red;

                            Label2.Text = "Select Only word Files  ";                              // if file is other than speified extension 

                        }
                    }



                    catch (Exception ex)

                    {

                        Label2.Text = "Error: " + ex.Message.ToString();

                    }
                    cn.Close();

                }
            }
            }

        

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
           
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string fn = e.CommandArgument.ToString();
            Response.Redirect("download.ashx?fn=" + fn);
            Response.Write("name : " + fn);
        }
    }
}

    
    
