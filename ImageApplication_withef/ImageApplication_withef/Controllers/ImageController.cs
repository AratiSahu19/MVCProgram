using ImageApplication_withef.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace ImageApplication_withef.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Image_table iList)
        {
            string filename = Path.GetFileNameWithoutExtension(iList.ImageFile.FileName);
            string extension = Path.GetExtension(iList.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            iList.Image = "~/Image/" + filename;
            filename = Path.Combine(Server.MapPath("~/Image/"), filename);
            iList.ImageFile.SaveAs(filename);
            using (dbModelss db = new dbModelss())

            {

                db.Image_table.Add(iList);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Image_table img = new Image_table();
            using (dbModelss db = new dbModelss())
            {
                img = db.Image_table.Where(x => x.Id == id).FirstOrDefault();
            }
            return View(img);
        }
    }
}