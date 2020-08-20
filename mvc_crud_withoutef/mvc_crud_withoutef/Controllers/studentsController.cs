using mvc_crud_withoutef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;using System.Configuration;
using System.Data;
using System.Data.SqlClient; 

namespace mvc_crud_withoutef.Controllers
{
    public class studentsController : Controller
    {
        // GET: students
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Addstudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addstudent(studentmodel iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
               studentdbHandler db = new studentdbHandler();
                if (db.InsertStudent(iList))
                {
                    ViewBag.Message = "Student Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
           
        }

        //list
        public ActionResult getlist()
        {
            ViewBag.ItemList = "List of Student";
            studentdbHandler db = new studentdbHandler();
            ModelState.Clear();
            return View(db.Getstudlist());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            studentdbHandler db = new studentdbHandler();
            return View(db.Getstudlist().Find(itemmodel => itemmodel.Id ==id));
        }
        [HttpPost]
        public ActionResult Edit(int id, studentmodel iList)
        {
            try
            {
                studentdbHandler db = new studentdbHandler();
                db.Updatestud(iList);
                return RedirectToAction("getlist");
            }
            catch { return View(); }
        }

        public ActionResult Delete(int id)
        {
            try
            {

                studentdbHandler db = new studentdbHandler();
                if (db.Deletestud(id))
                {
                    ViewBag.AlertMsg = "Student Deleted Successfully";
                }
                return RedirectToAction("getlist");
            }
            catch { return View(); }
        }

        //public ActionResult Details(int id)
        //{
        //     studentdbHandler db = new studentdbHandler();
        //     if (db.Deletestud(id))
        //         return View(db.Getstudlist().Find(itemmodel => itemmodel.Id == id));
        //} [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(studentmodel sm)

        {
            string constr = ConfigurationManager.ConnectionStrings["constudent"].ToString();
            SqlConnection con = new SqlConnection(constr);
            string qr = "select email , pass from student_info where email=@email and pass = @password";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@email", sm.email);
            cmd.Parameters.AddWithValue("@password", sm.password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["email"] = sm.email.ToString();
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewData["Message"] = "invalid credential";
            }
            con.Close();
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }



}
