using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

namespace New_SPS_project
{
    public partial class facultydashboard : System.Web.UI.Page


    {
       
        string course;
        string em;

        public static byte[] StrToByteArray(string value)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(value);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                em = Session["email_id"].ToString();
                Response.Write(em);
                Label3.Text = em;
                string qr1 = "select course from Register_DB where email_id='" + em + "' ";
                SqlCommand command1 = new SqlCommand(qr1, cn);
                course = Convert.ToString(command1.ExecuteScalar());
                Response.Write(course);

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
            Label2.Visible = true;

            // getting the file path of uploaded file



            if (!FileUpload1.HasFile)
            {
                Response.Write("No file Selected"); return;
            }
            else
            {
                string fn = "";
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                fn = FileUpload1.FileName;
                Response.Write(fn);
                Label3.Text = "filename " + fn;
                FileUpload1.SaveAs(Server.MapPath("~/Data/") + fn);
               // FileUpload1.SaveAs(fn);
                string course = DropDownList1.Text;
                string data = FileUpload1.ToString();
                //string extension = Path.GetExtension(filename);
                string date1 = TextBox2.Text;
                HttpPostedFile file = FileUpload1.PostedFile;
                string filename1 = Path.GetFileName(filename);               // getting the file name of uploaded file

                string ext = Path.GetExtension(filename1);                      // getting the file extension of uploaded file

                string type = String.Empty;



                using (SqlConnection connection = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
                {


                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
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

                            string commandText = @"insert into Assignment_DB(course,type,filename,data,date)values(@course,@type,@filename,@data,@date1)";

                            cmd.CommandText = commandText;
                            cmd.CommandType = System.Data.CommandType.Text;



                            cmd.Parameters.Add("@course", SqlDbType.NVarChar);
                            cmd.Parameters["@course"].Value = course;

                            cmd.Parameters.Add("@type", SqlDbType.NVarChar);
                            cmd.Parameters["@type"].Value = type;

                            cmd.Parameters.Add("@filename", SqlDbType.VarChar);
                            cmd.Parameters["@filename"].Value = filename;


                            cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value =
                StrToByteArray(data);




                            cmd.Parameters.Add("@date1", SqlDbType.Date);
                            cmd.Parameters["@date1"].Value = date1;

                            //cmd.Parameters["@extension"].Value = extension;


                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            connection.Close();
                            Response.Write("Data has been Added");



                            //else
                            //{
                            //    Response.Write("Inavlid File size");
                            //    return;
                            //}


                            //else
                            //{
                            //    Response.Write("Inavlid File");
                            //    return;
                            //}

                        }
                        catch (Exception ex)

                        {

                            Label2.Text = "Error: " + ex.Message.ToString();

                        }
                    }

                }
            }
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            //if (!IsPostBack)
            // {
            BindGrid();
            // }
        }
        private void BindGrid()

        {

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
            {
                //cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                string commandText = "select a.filename,date from  Assignment_DB as a left outer join Register_db as r on a.course=r.course where email_id= '" + em + " '";
                // string commandText = "select * from Register_db";
                cmd.CommandText = commandText;
                //  cmd.CommandType = System.Data.CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(commandText, cn);
                da.Fill(ds);

                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                // cn.Close();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                string commandText = "select * from Assignment_Submission  ";
                // string commandText = "select * from Register_db";
                cmd.CommandText = commandText;
                //  cmd.CommandType = System.Data.CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(commandText, cn);
                da.Fill(ds);

                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
                cn.Close();

            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //using (SqlConnection cn = new SqlConnection("data source = DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database = student_database"))
            //{
            //    //cn.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = cn;

            //    SqlCommand com = new SqlCommand("select filename,type,data from Assignment_Submission where id=@id", cn);
            //    com.Parameters.AddWithValue("id", GridView2.SelectedRow.Cells[1].Text);
            //    SqlDataReader dr = com.ExecuteReader();


            //    if (dr.Read())
            //    {
            //        Response.Clear();
            //        Response.Buffer = true;
            //        Response.ContentType = dr["type"].ToString();
            //        Response.AddHeader("content-disposition", "attachment;filename=" + dr["filename"].ToString());     // to open file prompt Box open or Save file         
            //        Response.Charset = "";
            //        Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //        Response.BinaryWrite((byte[])dr["data"]);
            //        Response.End();
            //    }
            //}
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string fn = e.CommandArgument.ToString();
            Response.Redirect("download.ashx?fn=" + fn);
            Response.Write("name : " + fn);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
