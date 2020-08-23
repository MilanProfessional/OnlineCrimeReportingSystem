using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class LoginController : Controller
    {

        private DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: Login
        public ActionResult LoginView()
        {
            return View();
        }
        public ActionResult LoginUser(LoginModel loginModel)
        {
            var res = context.UserProfiles.Where(p => p.Email == loginModel.Email && p.Password == loginModel.Password).FirstOrDefault();
            if (res != null)
            {
                FormsAuthentication.SetAuthCookie(res.Email, false);


                HttpCookie id = new HttpCookie("id");
                id.Value = Convert.ToString(res.Id);
                this.Response.Cookies["id"].Expires = DateTime.Now.AddMinutes(30);
                Request.Cookies.Add(id);

                //actionresult(view), Controller
                return RedirectToAction("CrimeReportView", "CrimeReport");
            }
            else
            {
                //LoginController's actionResult(LoginView)
                return RedirectToAction("LoginView");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index" ,"Home");
        }
    }
}