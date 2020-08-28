using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace mvc_crud_withoutef.Models
{
    public class studentdbHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["constudent"].ToString();
            con =new SqlConnection(constring);

        }
        //Insert Method

        public bool InsertStudent(studentmodel iList)
        {
            connection();
            string s = null;
            if (iList.status==true)
            {
               s = "Active";

            }
            else
            {
                s = "Not Active";
            }
            string qr = "insert into student_info values('" + iList.firstname + "','" + iList.lastname + "','"+iList.mobile+"','"+iList.gender+"','"+iList.dob+ "','" + iList.caddress + "','" + iList.paddress + "','" + iList.stream + "','" + iList.course + "','" + iList.email + "','" + iList.password + "','" + iList.photo + "','" + s + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
                return false;
        }

        //list of student

        public List<studentmodel> Getstudlist()
        {
            connection();
            List<studentmodel> iList = new List<studentmodel>();
            string query = "SELECT Id,firstname,lastname,mobile,gender,dob,caddress,paddress,stream,course,email,password,photo,status FROM student_info";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                string Astatus = Convert.ToString(dr["status"]);
                string s = null;
                if(Astatus == "Active")
                {
                    s = "Active";

                }
                else if(Astatus== "Not Active")
                {
                    s = "Not Active";
                }
                iList.Add(new studentmodel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    firstname = Convert.ToString(dr["firstname"]),
                    lastname = Convert.ToString(dr["lastname"]),
                    mobile = Convert.ToString(dr["mobile"]),
                    gender = Convert.ToString(dr["gender"]),
                    dob = Convert.ToString(dr["dob"]),
                    caddress = Convert.ToString(dr["caddress"]),
                    paddress = Convert.ToString(dr["paddress"]),
                    streamp =Convert.ToString(dr["stream"]),
                    course = Convert.ToString(dr["course"]),
                   email = Convert.ToString(dr["email"]),
                   password=Convert.ToString(dr["password"]),

                  
                  
                    photo = Convert.ToString(dr["photo"])

                });
            }
            return iList;


        }

        //Update

        public bool Updatestud(studentmodel iList)
        {
            connection();
            string query = "update student_info set firstname = '" + iList.firstname + "', lastname = '" + iList.lastname + "',gender = '" + iList.gender + "',caddress = '" + iList.caddress + "',paddress= '" + iList.paddress + "',stream= '" + iList.stream + "',course= '" + iList.course + "',email= '" + iList.email + "',status= '" + iList.status + "' WHERE Id = " + iList.Id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        //delete
        public bool Deletestud(int id)
        {
            connection();
            string query = "DELETE FROM student_info WHERE Id = " + id;
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
