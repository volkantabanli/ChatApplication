using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
       private UserManager userManager = new UserManager();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            var obj = userManager.GetUser(user);

            if (obj != null)
            {
                FormsAuthentication.SetAuthCookie(obj.Mail, false);
                Session.Add("UserId)", obj.UserId);
                Session.Add("FirstName", obj.FirstName);
                Session.Add("LastName", obj.LastName);
                Session.Add("Mail", obj.Mail);
                Session.Add("Password", obj.Password);
                return RedirectToAction("Index", "User");


            }
            else
            {
               
                return RedirectToAction("Index", "Home");

            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.RemoveAll();
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}