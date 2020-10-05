using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using bookstore_mvc.Models;

namespace bookstore_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Registermodel iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                registerdbhandler db = new registerdbhandler();
                if (db.Insert(iList))
                {
                    ViewBag.Message = "Registered Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Registermodel rm)

        {
            string constr = ConfigurationManager.ConnectionStrings["conbook"].ToString();
            SqlConnection con = new SqlConnection(constr);
            string qr = "select email , password from registrationtb where email=@email and password = @password";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@email", rm.email);
            cmd.Parameters.AddWithValue("@password", rm.password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["email"] = rm.email.ToString();
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
            string constr = ConfigurationManager.ConnectionStrings["conbook"].ToString();
            SqlConnection con = new SqlConnection(constr);
            string qr = "select  firstname,lastname,gender from registrationtb where email='" + Session["email"] + "' ";
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "registrationtb");
            foreach (DataRow dr in ds.Tables["registrationtb"].Rows)
            {
                ViewData["fn"] = dr["firstname"].ToString();
                ViewData["ln"] = dr["lastname"].ToString();

                ViewData["gen"] = dr["gender"].ToString();

            }
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
