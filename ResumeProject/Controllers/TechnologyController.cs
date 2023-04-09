using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        DbResumeEntities5 db = new DbResumeEntities5();
        public ActionResult Index()
        {
            var values = db.TBLTECNOLOGY.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult addTECNOLOGY()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addTECNOLOGY(TBLTECNOLOGY D)
        {
            db.TBLTECNOLOGY.Add(D);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteTECNOLOGY(int id)
        {
            var value = db.TBLTECNOLOGY.Find(id);
            db.TBLTECNOLOGY.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public ActionResult updateTECNOLOGY(int id)
        {

            var value = db.TBLTECNOLOGY.Find(id);
                return View(value);
        }
        [HttpPost]
    
                  public ActionResult updateTECNOLOGY(TBLTECNOLOGY P)
                   {

                     var value = db.TBLTECNOLOGY.Find(P.TechnologyID);
                     value.TechnologyTitle = P.TechnologyTitle;
                     value.TechnologyValue=P.TechnologyValue;
                      db.SaveChanges();
                      return RedirectToAction("Index");
           

                    }



    }
}