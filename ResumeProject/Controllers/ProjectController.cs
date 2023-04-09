using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ProjectController : Controller
    {
        DbResumeEntities5 db=new DbResumeEntities5();
        public ActionResult Index()
        {
            var value = db.TBLPROJECT.ToList();
            return View(value);
        }
        public ActionResult DeleteProject(int id)
        {
            var valius = db.TBLPROJECT.Find(id);
            db.TBLPROJECT.Remove(valius);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult AddProject()
        { 
        return View();
        }

        [HttpPost]
        public ActionResult AddProject(TBLPROJECT a)
         {
            db.TBLPROJECT.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }
        [HttpGet]
        public ActionResult UpdateProject(int id) 
        {
            var value = db.TBLPROJECT.Find(id);
             return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(TBLPROJECT a)
        {
            var values = db.TBLPROJECT.Find(a.ProjectID);
            values.ProjectTitle = a.ProjectTitle;
            values.ProjectDescription=a.ProjectDescription;
            values.ProjectImageUrl=a.ProjectImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }


}