using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class CategoryController : Controller
    {
        DbResumeEntities5 db = new DbResumeEntities5();
        public ActionResult Index()
        {
            var values=db.TBLCATEGORY.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(TBLCATEGORY C)
        {
            db.TBLCATEGORY.Add(C);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {       
            var values=db.TBLCATEGORY.Find(id);
            db.TBLCATEGORY.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateCategory(int id) 
        {
            var values = db.TBLCATEGORY.Find(id);
            return View(values);
        
        }
        [HttpPost]
        public ActionResult UpdateCategory(TBLCATEGORY c)
        {
            var values=db.TBLCATEGORY.Find(c.CategoryID);
            values.CategoryName=c.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetMessageBySubject(int id)
        {
            var values = db.TBLCONTACT.Where(x=>x.Subject==id).ToList();
            return View(values);

        }
    }
}