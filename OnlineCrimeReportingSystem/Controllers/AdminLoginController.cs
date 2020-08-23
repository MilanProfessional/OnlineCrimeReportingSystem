using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class AdminLoginController : Controller
    {
        private DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: AdminLogin
        public ActionResult AdminLoginView()
        {
            return View();
        }

         public ActionResult LoginAdmin(AdminLoginModel AdminloginModel)
        {
            var res = context.AdminProfiles.Where(p => p.Email == AdminloginModel.Email && p.Password == AdminloginModel.Password).ToList();
            if (res.Count > 0)
            {
                FormsAuthentication.SetAuthCookie(AdminloginModel.Email, false);
                //actionresult(view), Controller
                return RedirectToAction("", "");
            }
            else
            {
                //LoginController's actionResult(LoginView)
                return RedirectToAction("AdminLoginView");
            }
        }
    }
}