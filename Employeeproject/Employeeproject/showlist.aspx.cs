using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Employeeproject
{
    public partial class showlist : System.Web.UI.Page
    {
        static string strcon = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                show();
            }
        }
        public void show()
        {
            string qr = "select Emp_Id,First_Name,Last_Name,Gender,Date_of_birth,designation,Email_Id,Status from Emp_Table";
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            con.Open();
            int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["Emp_Id"].ToString());
            SqlCommand cmd = new SqlCommand("delete from Emp_Table where Emp_Id=@Emp_Id", con);
            cmd.Parameters.AddWithValue("@Emp_Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            show();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            con.Open();
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Emp_Id"].ToString());
            TextBox chkstatus = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;

            SqlCommand cmd = new SqlCommand("update Emp_table set Status=@Status where Emp_Id=@Emp_Id", con);
            cmd.Parameters.AddWithValue("@Status",chkstatus.Text);
            cmd.Parameters.AddWithValue("@Emp_Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            show();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            show();
        }
    }
}