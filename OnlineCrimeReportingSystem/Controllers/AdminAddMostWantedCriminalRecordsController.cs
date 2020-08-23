using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    [Authorize]
    public class AdminAddMostWantedCriminalRecordsController : Controller
    {

        DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: AdminAddMostWantedCriminalRecords
        public ActionResult AdminAddMostWantedCriminalRecordsView()
        {
            return View();
        }

        public ActionResult SaveCriminalRecordsInDatabase(AdminCriminalRecord adminCriminalRecord, HttpPostedFileBase file)
        {
            try
            {
                string fileName = "";
                if (file.ContentLength > 0)
                {
                    fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/images"), fileName);
                    file.SaveAs(path);
                }

                adminCriminalRecord.Image = fileName;
                context.AdminCriminalRecords.Add(adminCriminalRecord);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("AdminMostWantedCriminalView", "AdminMostWantedCriminal");
        }

        public ActionResult UpdateCriminalRecords(int id)
        {
            var res = context.AdminCriminalRecords.Find(id);
            return View(res);
        }

        public ActionResult UpdateCriminalRecordsOfDatabase(AdminCriminalRecord adminCriminalRecord)
        {
            try
            {
                context.Entry(adminCriminalRecord).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("AdminMostWantedCriminalView" , "AdminMostWantedCriminal");
        }

        public ActionResult UploadPhoto(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("AdminAddMostWantedCriminalRecordsView");
        }
    }
}