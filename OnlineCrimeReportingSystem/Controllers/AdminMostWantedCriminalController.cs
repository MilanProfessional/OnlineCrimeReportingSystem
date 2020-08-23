using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class AdminMostWantedCriminalController : Controller
    {
        DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: AdminMostWantedCriminal
        public ActionResult AdminMostWantedCriminalView()
        {
            var res = context.AdminCriminalRecords.ToList();
            return View(res);
        }

        public ActionResult DeleteCriminalDetails(int id)
        {
            var data = context.AdminCriminalRecords.Find(id);
            context.AdminCriminalRecords.Remove(data);
            context.SaveChanges();
            return RedirectToAction("AdminMostWantedCriminalView");
           
        }



    }
}