using OnlineCrimeReportingSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class SendMailToUsersController : Controller
    {
        // GET: SendMailToUsers
        public ActionResult SendMailToUsersView()
        {
            return View();
        }

        public async Task<ActionResult> SendMail(FormCollection fc)
        {
            string message = fc["message"];
            string recepient = fc["email"];
            string subject = fc["subject"];

            await MailSender.SendEmail(subject, message, recepient);

            return RedirectToAction("AdminViewContactUsMessageView" , "AdminViewContactUsMessage");
        }

        public async Task<ActionResult> SendMailToAdmin(FormCollection fc)
        {
            string message = fc["message"];
            string email = fc["email"];
            string subject = fc["subject"];
            string password = fc["password"];

            await MailSender.SendEmailToAdmin(subject, message, email, password);

            return RedirectToAction(" AdminViewContactUsMessageView" , " AdminViewContactUsMessage");
        }
    }
}