using mvc_Emp_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace mvc_Emp_Registration.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpModel iList)
        {
            if (ModelState.IsValid)
            {
                EmpDbHandler db = new EmpDbHandler();
                if (db.InsertEmp(iList))
                {
                    ViewBag.Message = "registration successful";
                }

            }
            return View();
        }
        public ActionResult GetList()
        {
            ViewBag.Message = "Employee List";
            EmpDbHandler db = new EmpDbHandler();
            ModelState.Clear();
            return View(db.GetEmpList());
        }
        [HttpGet]
        public ActionResult Edit(string Email_Id)
        {
            EmpDbHandler db = new EmpDbHandler();
            return View(db.GetEmpList().Find(itemmodel => itemmodel.Email_Id == Email_Id));
        }
        [HttpPost]
        public ActionResult Edit(int id, EmpModel iList)
        {
            try
            {
                EmpDbHandler db = new EmpDbHandler();
                db.UpdateEmp(iList);
                return RedirectToAction("GetList");
            }
            catch { return View(); }
        }



        public ActionResult Delete(string Email_Id)
        {
            try
            {
                EmpDbHandler db = new EmpDbHandler();
                if (db.DeleteEmp(Email_Id))
                {
                    ViewBag.AlertMsg = "Emp Deleted Successfully";
                }
                return RedirectToAction("GetList");
            }
            catch { return View(); }
        }

        public ActionResult Details(string Email_Id)
        {
            EmpDbHandler db = new EmpDbHandler();
            return View(db.GetEmpList().Find(itemmodel => itemmodel.Email_Id == Email_Id));
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(EmpModel ls)

        {
            string constr = ConfigurationManager.ConnectionStrings["constring"].ToString();
            SqlConnection con = new SqlConnection(constr);
            string qr = "select Email_Id , Password from Emp_Table where Email_Id=@Email_Id and Password = @Password";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@Email_Id", ls.Email_Id);
            cmd.Parameters.AddWithValue("@Password", ls.Password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["Email_Id"] = ls.Email_Id.ToString();
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
        public ActionResult logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}


