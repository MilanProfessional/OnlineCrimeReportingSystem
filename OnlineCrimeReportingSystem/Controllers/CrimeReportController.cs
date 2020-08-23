using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    [Authorize]
    public class CrimeReportController : Controller
    {
        DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();

        // GET: CrimeReport
        public ActionResult CrimeReportView()
        {
            return View();
        }

        public ActionResult SaveCrimeReportInDatabase(FormCollection form, HttpPostedFileBase file)
        {
            string fileName = "";
            if (file.ContentLength > 0)
            {
                fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images"), fileName);
                file.SaveAs(path);
            }

            var crimereport = new Crime
            {
                Message = form["Message"],
                CrimeDate = Convert.ToDateTime(form["CrimeDate"]),
                Name = form["Name"],
                CriminalName = form["CriminalName"],
                Email = form["Email"],
                Subject = string.IsNullOrEmpty(form["Subject"]) ? form["Other"] : form["Subject"],
                Location = form["Location"],
                Files = fileName,
                ReportingDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            try
            {
                context.Crimes.Add(crimereport);
                context.SaveChanges();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return  RedirectToAction("RetrieveCrimeReportView", "RetrieveCrimeReport");         

        }

        public ActionResult UpdateCrimeReport(int id)
        {
            var res = context.Crimes.Find(id);
            return View(res);
        }

        public ActionResult UpdateCrimeReportOfDatabase(Crime crime)
        {
            try
            {
                context.Entry(crime).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("RetrieveCrimeReportView", "RetrieveCrimeReport");
        }
    }
}