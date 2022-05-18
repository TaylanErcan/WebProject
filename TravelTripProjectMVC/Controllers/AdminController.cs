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
        [Authorize]
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
            context.Blogs.Add(b);
            context.SaveChanges(); // executeNoNQuery muadili
            return RedirectToAction("Index");
        }

        public ActionResult BlogDelete(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id) 
        {
            var blog = context.Blogs.Find(id);
            return View("GetBlog", blog);
        }

        public ActionResult BlogUpdate(Blog blog) 
        {
            var blg = context.Blogs.Find(blog.Id);
            blg.Aciklama = blog.Aciklama;
            blg.Title = blog.Title;
            blg.Date = blog.Date;
            blg.BlogImagePath = blog.BlogImagePath;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetCommentList()
        {
            var values = context.Comments.ToList();
            return View(values);
        }

        public ActionResult CommentDelete(int id) {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("GetCommentList");
        }

        public ActionResult GetComment(int id)
        {
            var cmm = context.Comments.Find(id);
            return View("GetComment", cmm);
        }

        public ActionResult CommentUpdate(Comment comment)
        {
            var cmm = context.Comments.Find(comment.Id);
            cmm.User_Name = comment.User_Name;
            cmm.Mail = comment.Mail;
            cmm.UserComment = comment.UserComment;
            context.SaveChanges();
            return RedirectToAction("GetCommentList");
        }
    }   

}