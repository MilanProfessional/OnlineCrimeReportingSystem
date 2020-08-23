using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class UserRegisterController : Controller
    {
        private readonly DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();

        public UserRegisterController()
        {

        }
        // GET: UserRegister
        //view
        public ActionResult UserRegisterView()
        {
            return View();
        }

        //save into database
        public ActionResult SaveRegisterUserInDatabase(UserProfile userProfile)
        {
            context.UserProfiles.Add(userProfile);
            context.SaveChanges();

            return RedirectToAction("LoginView" , "Login");
        }

        public ActionResult ChangeOrUpdatePassword(UpdatePassword pas)
        {

            var res = context.UserProfiles.Where(p => p.Email == pas.Email).FirstOrDefault();
            return View(res);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ChangeOrUpdatePasswordOfDatabase(UserProfile userProfile)
        {
            try
            {
                context.Entry(userProfile).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("Logout");
        }
    }
}