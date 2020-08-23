using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    [Authorize]
    public class AdminRetrieveCrimeReportController : Controller
    {
        private DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: AdminRetrieveCrimeReport
        public ActionResult AdminRetrieveCrimeReportView()
        {
            var model = context.Crimes.ToList();
            return View(model);
        }

        public ActionResult DeactiveCrime(int id)
        {
            var crime = context.Crimes.Find(id);
            crime.Status = false;

            context.Entry(crime).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction("AdminRetrieveCrimeReportView");
        }
    }
}