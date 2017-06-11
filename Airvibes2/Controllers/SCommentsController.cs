using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Airvibes2.Models;
using Microsoft.AspNet.Identity;

namespace Airvibes2.Controllers
{
    public class SCommentsController : Controller
    {
        // GET: SComments
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(SComment resultat)
        {
            if (!Request.IsAuthenticated)
            {
                return Redirect("https://localhost:44388/Account/Login");
            }
            else
            {
                var context = new ApplicationDbContext();
                SComment comment = resultat;
                comment.Users_Id = User.Identity.GetUserId();
                comment.PostedAt = DateTime.Now;
                context.SComment.Add(comment);
                context.SaveChanges();
                ViewBag.CurrentUser = User.Identity.Name;
                ViewBag.CurrentId = User.Identity.GetUserId();
                var Record_Id = context.Songs.Where(s => s.Id == comment.Songs_Id).FirstOrDefault().Records_Id;
                return new EmptyResult();
            }
        }

        [HttpPost]
        public ActionResult Delete(SComment comToDelete)
        {
            int comId = comToDelete.Id;
            var Song_Id = comToDelete.Songs_Id;
            var context = new ApplicationDbContext();
            var Record_Id = context.Songs.Where(s => s.Id == Song_Id).First().Records_Id;

            SComment commentASupprimer = new SComment();
            commentASupprimer = context.SComment.Where(sc => sc.Id == comId).FirstOrDefault();
            if(commentASupprimer != null)
            {
                context.SComment.Remove(commentASupprimer);
                context.SaveChanges();
            }
            return Redirect("/Records/Details/" + Record_Id);
        }
    }
}