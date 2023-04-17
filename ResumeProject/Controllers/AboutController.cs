using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class AboutController : Controller
    {
        DbResumeEntities5 db = new DbResumeEntities5();
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialTechnology()
        {
            var values = db.TBLTECNOLOGY.ToList();

            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();

        }
        public PartialViewResult PartialTestimonials()
        {
            return PartialView();
        }
    }
}