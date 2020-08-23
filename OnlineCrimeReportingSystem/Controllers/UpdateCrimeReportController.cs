using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class UpdateCrimeReportController : Controller
    {
        private DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: UpdateCrimeReport
        public ActionResult UpdateCrimeReportView(int id)
        {
            string loggedInEmail = User.Identity.Name;
            var list = context.Crimes.Where(p => p.Id == id).FirstOrDefault();

            if (list.Email != loggedInEmail)
            {
                ViewData["error"] = "You are not logged in";
                return View(list);
            } else
            {
                return View(list);
            }
        }

        public ActionResult UpdateCrimeReportOfDatabase(Crime crime, HttpPostedFileBase file)
        {

            string fileName = "";
            if (file.ContentLength > 0)
            {
                fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images"), fileName);
                file.SaveAs(path);
            }


            try
            {
                crime.UpdateDate = System.DateTime.Now;
                crime.Files = fileName;
                context.Entry(crime).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("RetrieveCrimeReportView" , "RetrieveCrimeReport");
        }
    }
}