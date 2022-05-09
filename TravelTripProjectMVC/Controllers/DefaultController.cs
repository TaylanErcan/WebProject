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
            var values = context.Blogs.Take(5).ToList();
            return View(values);
        }

        public ActionResult About()
        {

            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var value = context.Blogs.Where(x=> x.Id==5).ToList(); // temporary solution
            return PartialView(value);
        }

        public PartialViewResult Partial3()
        {
            var value = context.Blogs.ToList();
            return PartialView(value);
        }

        public PartialViewResult Partial4()
        {
            var value = context.Blogs.Take(3).ToList();
            return PartialView(value); 
        }
    }
}