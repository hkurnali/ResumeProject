using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
        DbResumeEntities5 db = new DbResumeEntities5();
        public ActionResult Index()
        {
            var values = db.TBLSKILL.ToList();

            return View(values);
        }


        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
       public ActionResult AddSkill(TBLSKILL d)
        {
            db.TBLSKILL.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");

        }   

        public ActionResult DeleteSkill(int id) 
        {
           var value= db.TBLSKILL.Find(id);
            db.TBLSKILL.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id) 
        { 
            var value=db.TBLSKILL.Find(id);
            return View(value);
        
        }
        [HttpPost]

        public ActionResult UpdateSkill(TBLSKILL b)
        {
           var value= db.TBLSKILL.Find(b.SkillID);
            value.SkillTitle = b.SkillTitle;
            value.Skillicon=b.Skillicon;
            value.SkillDescription = b.SkillDescription;

            db.SaveChanges();
            return RedirectToAction("Index");
           


        }
    }
   

}