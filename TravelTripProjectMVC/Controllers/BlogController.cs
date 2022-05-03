﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectMVC.Models.Classes;

namespace TravelTripProjectMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }

        BlogComment bComment = new BlogComment();

        public ActionResult BlogDetail(int id)
        {
            // var blogBul = c.Blogs.Where(x => x.Id == id).ToList();
            bComment.Deger1 = c.Blogs.Where(x => x.Id == id).ToList();
            bComment.Deger2 = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(bComment);
        }
    }
}