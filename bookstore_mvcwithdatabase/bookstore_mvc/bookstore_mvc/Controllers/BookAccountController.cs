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
    public class BookAccountController : Controller
    {
        // GET: BookAccount
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Bookstoremodel iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                BookstoredbHandler db = new BookstoredbHandler();
                if (db.InsertBook(iList))
                {
                    ViewBag.Message = "Book Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }

        public ActionResult BookList()
        {
            ViewBag.BookList = "List of Book in Store";
            BookstoredbHandler IHandler = new BookstoredbHandler();
            ModelState.Clear();
            return View(IHandler.GetBookList());
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            BookstoredbHandler db = new BookstoredbHandler();
            return View(db.GetBookList().Find(itemmodel => itemmodel.Id == Id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Bookstoremodel iList)
        {
            try
            {
                BookstoredbHandler db = new BookstoredbHandler();
                db.UpdateBook(iList);
                return RedirectToAction("BookList");
            }
            catch { return View(); }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                BookstoredbHandler db = new BookstoredbHandler();
                if (db.DeleteBook(id))
                {
                    ViewBag.AlertMsg = "Book Details Deleted Successfully";
                }
                return RedirectToAction("BookList");
            }
            catch { return View(); }
        }

    }
}