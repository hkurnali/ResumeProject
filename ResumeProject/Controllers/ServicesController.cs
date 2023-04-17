using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialProjects()
        {
            return PartialView();
        }
        public PartialViewResult PartialSection()
        {
            return PartialView();
        }
    }
}