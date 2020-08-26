using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace grid_view
{
    public partial class list : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-PD940DJ\\SQLEXPRESS;integrated security=true;database=student_database");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                datashow();
            }
           
             void datashow()
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from Register_db",con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                GridView1.DataSource = dt;
                //GridView1.DataBind();


            
            
            }
        }
    }
}