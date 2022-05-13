using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectMVC.Models.Classes;

namespace TravelTripProjectMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewBlog() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog b) 
        {
            return View();
        }
    }   

}