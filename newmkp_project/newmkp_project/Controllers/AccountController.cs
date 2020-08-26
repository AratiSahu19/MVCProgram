using newmkp_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace newmkp_project.Controllers
{
    public class AccountController : Controller
    {
        public mkdatabaseEntities db = new mkdatabaseEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User Model)
        {
           

              using (var context = new mkdatabaseEntities())
                {
                    context.Users.Add(Model);
                    context.SaveChanges();
                }
            
                return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login( User Model)
        {
            using(var context =new mkdatabaseEntities())
            {
                bool isvalid = context.Users.Any(x => x.Email_Id == Model.Email_Id && x.Password == Model.Password);
                if(isvalid)
                {
                    FormsAuthentication.SetAuthCookie(Model.Email_Id, false);
                    return RedirectToAction("UserDashboard");
                }
                ModelState.AddModelError("", "Invalid emailId and password");

                    
            }
            return View();
        }

        [HttpGet]
        public ActionResult UserDashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}