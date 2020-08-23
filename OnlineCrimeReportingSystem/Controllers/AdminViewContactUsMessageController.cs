using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    [Authorize]
    public class AdminViewContactUsMessageController : Controller
    {
        DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        private string connectionString;

        // GET: AdminViewContactUsMessage
        public ActionResult AdminViewContactUsMessageView()
        {
            var model = context.ContactUsMessages.ToList();
            return View(model);
        }

        public ActionResult DeleteSomething(int id)
        {
            var data = context.ContactUsMessages.Find(id);
            context.ContactUsMessages.Remove(data);
            context.SaveChanges();
          return  RedirectToAction("AdminViewContactUsMessageView");
        }


    }
}