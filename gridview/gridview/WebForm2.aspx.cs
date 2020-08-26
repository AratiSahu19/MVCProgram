using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gridview
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIJR5L2\\sqlexpress;integrated security=true;database=practicedb");

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                datashow();
            }
        }
            public void  datashow()
            {
            SqlDataAdapter da = new SqlDataAdapter("select * from students", "Data Source = DESKTOP - RIJR5L2\\sqlexpress; integrated security = true; database=practicedb");
            DataTable dt = new DataTable();
           // DataSet dt = new DataSet();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            }

        }
    }

