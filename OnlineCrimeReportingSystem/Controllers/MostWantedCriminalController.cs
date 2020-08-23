using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class MostWantedCriminalController : Controller
    {
        DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: MostWantedCriminal
        public ActionResult MostWantedCriminalView()
        {
            var res = context.AdminCriminalRecords.ToList();
            return View(res);
        }
    }
}