using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    [Authorize]
    public class CrimeTypeController : Controller
    {
        private DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: CrimeType
        public ActionResult CrimeTypes()
        {
            return View();
        }

        public ActionResult SaveCrimeType(CrimeType crimeType)
        {
            context.CrimeTypes.Add(crimeType);
            context.SaveChanges();

            return RedirectToAction("CrimeTypes");
        }
    }
}