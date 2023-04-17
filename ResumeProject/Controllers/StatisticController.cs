using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
     DbResumeEntities5 db=new DbResumeEntities5();
        public ActionResult Index()
        {
            //ViewBag.skillCount = db.TBLSKILL.Count();
            ViewBag.destekMesaji=db.CountDestekMesaji().FirstOrDefault();
            ViewBag.tecnologyCount=db.TBLTECNOLOGY.Count();
            ViewBag.csharbValue=db.TBLTECNOLOGY.Where(x=>x.TechnologyTitle=="C#").Select(y=>y.TechnologyValue).FirstOrDefault();
            ViewBag.contantCount=db.TBLCONTACT.Count();
            ViewBag.subjectTesekkur = db.TBLCONTACT.Where( x => x.Subject == 1).Count();
            ViewBag.sumTechnolgyValue = db.TBLTECNOLOGY.Sum(x => x.TechnologyValue);
            ViewBag.avregeTechnologyValue = db.TBLTECNOLOGY.Average(x => x.TechnologyValue);
            ViewBag.GetBy3ID=db.TBLSKILL.Where(x=>x.SkillID==3).Select(y=>y.SkillTitle).FirstOrDefault();
            ViewBag.mxtECHNOLOGYvALUE = db.TBLTECNOLOGY.Max(x => x.TechnologyValue);
            return View();
        }
    }
}