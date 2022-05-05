using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectMVC.Models.Classes;

namespace TravelTripProjectMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context context = new Context();

        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        public ActionResult About()
        {

            return View();
        }
    }
}