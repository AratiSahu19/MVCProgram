using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Student_registeration
{
    public partial class gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string strcon = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            //if(!IsPostBack)
            //{
            //    show();
            //}
            //void show()
            //{
                string qr = "select Id,firstname,lastname,mobile,gender,dob,caddress,paddress,stream,course,email,status from student_info";
                SqlDataAdapter da = new SqlDataAdapter(qr, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource=ds;
                GridView1.DataBind();

            //}

        }
    }
}