using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;


namespace ResumeProject.Controllers
{
    public class ProfileController : Controller
    {
        DbResumeEntities5 db = new DbResumeEntities5();
        public ActionResult Index()
        {
            var values = db.TBLPROFILE.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProfile(TBLPROFILE d)
        {
            db.TBLPROFILE.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteProfile(int id)
        {
            var value = db.TBLPROFILE.Find(id);
            db.TBLPROFILE.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = db.TBLPROFILE.Find(id);
            return View(value);

        }
        [HttpPost]

        public ActionResult UpdateProfile(TBLPROFILE b)
        {
            var value = db.TBLPROFILE.Find(b.ProfileID);
            value.ProfileTitle  = b.ProfileTitle;
            value.ProfileDescripton = b.ProfileDescripton;
            value.Name = b.Name;
            value.Mail = b.Mail;
            value.Address = b.Address;
            value.Phone = b.Phone;
            value.SocialMedia1 = b.SocialMedia1;
            value.SocialMedia2 = b.SocialMedia2;
            value.SocialMedia3 = b.SocialMedia3;
            value.SocialMedia4 = b.SocialMedia4;
            db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}