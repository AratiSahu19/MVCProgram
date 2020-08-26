using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace mvc_Emp_Registration.Models
{
    public class EmpDbHandler
    {

        static string constr = ConfigurationManager.ConnectionStrings["constring"].ToString();
        SqlConnection con = new SqlConnection(constr);




        public bool InsertEmp(EmpModel iList)
        {
            //connection();
            con.Open();
            string qr = "insert into Emp_Table values('" + iList.First_Name + "','" + iList.Last_Name + "','" + iList.Gender + "','" + iList.Date_of_birth + "','" + iList.Designation + "','" + iList.Email_Id + "','" + iList.Password + "','" + iList.Status + "')";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
        public List<EmpModel> GetEmpList()
        {
           // connection();
            List<EmpModel> iList = new List<EmpModel>();

            string query = "SELECT * FROM Emp_Table";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new EmpModel
                {

                    First_Name = Convert.ToString(dr["First_Name"]),
                    Last_Name = Convert.ToString(dr["Last_Name"]),
                    Gender = Convert.ToString(dr["Gender"]),
                    Date_of_birth=Convert.ToString(dr["Date_of_birth"]),
                    Designation=Convert.ToString(dr["Designation"]),
                    Email_Id=Convert.ToString(dr["Email_Id"]),
                    Password=Convert.ToString(dr["Password"]),
                    Status=Convert.ToString(dr["status"])
                });
            }
            return iList;
        }
        public bool UpdateEmp(EmpModel iList)
        {
           // connection();
            string query = "UPDATE Emp_Table SET First_Name = '" + iList.First_Name + "', Last_Name = '" + iList.Last_Name + "', Gender =' " + iList.Gender + "',Date_of_birth = '" + iList.Date_of_birth + "',Designation = '" + iList.Designation + "',Email_Id = '" + iList.Email_Id + "',Password = '" + iList.Password + "',Status = '" + iList.Status + "' WHERE Email_Id = " + iList.Email_Id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }



        public bool DeleteEmp(string Email_Id )
        {
           // connection();
            string query = "DELETE FROM Emp_Table WHERE Email_Id = " + Email_Id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }




    }
}
