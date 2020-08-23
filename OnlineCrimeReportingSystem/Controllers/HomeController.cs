using OnlineCrimeReportingSystem.Common;
using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class HomeController : Controller
    {
        DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        public ActionResult Index()
        {
            var res = context.AdminCriminalRecords.ToList();
            //string username = User.Identity.Name;
            //var userProfile = context.UserProfiles.Where(p =>p.Email == username).FirstOrDefault();
            //ViewData["user"] = userProfile;
            return View(res);
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SaveContactUsMessageInDatabase(FormCollection form)
        {
            var ContactMessage = new ContactUsMessage
            {
                Message = form["Message"],
                Name = form["Name"],
                Email = form["Email"],
                MobileNo = form["MobileNo"]
            };

            try
            {
                context.ContactUsMessages.Add(ContactMessage);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("Index", "Home");
        }


        //public async Task<ActionResult> SendMail(FormCollection fc)
        //{
        //    string message = fc["message"];
        //    string recepient = fc["email"];
        //    string subject = fc["subject"];

        //    await MailSender.SendEmail(subject, message, recepient);

        //    return RedirectToAction("AdminViewContactUsMessageView", "AdminViewContactUsMessage");
        //}

        //public async Task<ActionResult> SendMailToAdmin(FormCollection fc)
        //{
        //    string message = fc["message"];
        //    string email = fc["email"];
        //    string subject = fc["subject"];
        //    string password = fc["password"];

        //    await MailSender.SendEmailToAdmin(subject, message, email, password);

        //    return RedirectToAction("AdminViewContactUsMessageView", "AdminViewContactUsMessage");
        //}

    }
}