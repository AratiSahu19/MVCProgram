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
    public partial class studform : Form
    {
        public studform()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studform_Load(object sender, EventArgs e)
        {
           

        }
        public void show()
        {
            string strcon = "data source=.\\sqlexpress;integrated security=true;database=Student1_Db";
            SqlConnection con = new SqlConnection(strcon);
           
            string qr = "select Id,Name,class,Email_id,password from stud_table";
           con.Open();
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataTable ds = new DataTable();
            da.Fill(ds);

            con.Close();
           
            dataGridView1.DataSource = ds;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
