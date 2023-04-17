using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
       
        DbResumeEntities5 db = new DbResumeEntities5();
        public ActionResult Index()
        {
            var values = db.TBLCONTACT.ToList();

            return View(values);
        }
        public ActionResult DeleteContact(int id) 
        {
            var values = db.TBLCONTACT.Find(id);
            db.TBLCONTACT.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id) 
        {
            var values = db.TBLCONTACT.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateContact(TBLCONTACT c)
        {
            var values = db.TBLCONTACT.Find(c.ContactID);
            values.NameSurname = c.NameSurname;
            values.Mail=c.Mail;
            values.Subject=c.Subject;
            values.Message=c.Message;
            values.Date=c.Date;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SendMessage()
        { 
        List<SelectListItem> values = (from x in db.TBLCATEGORY.ToList() select new SelectListItem
        {
            Text=x.CategoryName,
            Value=x.CategoryID.ToString()
        } ).ToList();
            ViewBag.v=values;
            return View();
        }


        [HttpPost]
        public ActionResult SendMessage(TBLCONTACT p)
        {   p.Date= DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLCONTACT.Add(p); 
            db.SaveChanges();
            return RedirectToAction("Index","Default");
        }
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }

    }

}
 