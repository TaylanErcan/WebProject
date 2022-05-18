﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProjectMVC.Models.Classes;

namespace TravelTripProjectMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context context = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var infos = context.Admins.FirstOrDefault(x => x.Username == admin.Username &&
            x.Password == admin.Password);
            if (infos != null)
            {
                FormsAuthentication.SetAuthCookie(infos.Username, false);
                Session["Username"] = infos.Username.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }
    }
}