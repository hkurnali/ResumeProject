using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
   
    public class DefaultController : Controller
    {
        DbResumeEntities5 db = new DbResumeEntities5();

        public PartialViewResult PartialAbout()
        {
            var values=db.TBLPROFILE.ToList();
            return PartialView(values);
        }
        
        public ActionResult Index()
        {
            return View();
        }
       
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public ActionResult PartialService()
        {
            var values = db.TBLSERVICE.ToList();

            return PartialView(values);
        }
        public ActionResult PartialTechnology()
        {
            var values = db.TBLTECNOLOGY.ToList();

            return PartialView(values);
        }
        public ActionResult PartialCounter()
        {
           ViewBag.skillCount=db.TBLSKILL.Count();
            ViewBag.serviceCount = db.TBLSERVICE.Count();
            ViewBag.avgTechnologyValue = db.TBLTECNOLOGY.Average(x => x.TechnologyValue);
            ViewBag.happyCustomer = 38;

            return PartialView();
        }
        public ActionResult PartialProjects()
        {
            var values = db.TBLPROJECT.ToList();
          

            return PartialView(values);
        }
        public ActionResult PartialBrands()
        {


            return PartialView();
        }
        public ActionResult PartialFooter()
        {
            ViewBag.addressFooter=db.TBLPROFILE.Select(x => x.Address).FirstOrDefault();
            ViewBag.phoneFooter = db.TBLPROFILE.Select(x => x.Phone).FirstOrDefault();
            ViewBag.emailFooter = db.TBLPROFILE.Select(x => x.Mail).FirstOrDefault();
            ViewBag.smadia1Footer = db.TBLPROFILE.Select(x => x.SocialMedia1).FirstOrDefault();
            ViewBag.smadia2Footer = db.TBLPROFILE.Select(x => x.SocialMedia2).FirstOrDefault();
            ViewBag.smadia3Footer = db.TBLPROFILE.Select(x => x.SocialMedia3).FirstOrDefault();
            ViewBag.smadia4Footer = db.TBLPROFILE.Select(x => x.SocialMedia4).FirstOrDefault();
            return PartialView();
        }
        public ActionResult PartialScripts()
        {


            return PartialView();
        }
    }
}
