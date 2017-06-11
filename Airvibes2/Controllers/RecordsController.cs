using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Airvibes2.Models;

namespace Airvibes2.Controllers
{
    public class RecordsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Records
        public ActionResult Index()
        {
            var records = db.Records.ToList().OrderBy(m=>m.Artists_Id);
            return View(records);
        }

        // GET: Records/Details/5
        public ActionResult Details(int? id)
        {
            var context = new ApplicationDbContext();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Records records = db.Records.Find(id);
            
            if (records == null)
            {
                return HttpNotFound();
            }


            ViewBag.Cover = records.Cover;
            ViewBag.Title = records.Title;
            ViewBag.Genre = records.Genre;
            ViewBag.ReleaseDate = records.ReleaseDate;
            ViewBag.ArtistId = context.Artists.Where(a => a.Id == records.Artists_Id).First().Id;
            ViewBag.Artist = context.Artists.Where(a => a.Id == records.Artists_Id).First().Name ;

            var vm = new List<CommentaireChansons>();
            foreach (var item in context.Songs.Where(s=>s.Records_Id == records.Id))
            {
                CommentaireChansons vm2 = new CommentaireChansons();
                vm2.Songs = item;
                vm2.SComment = context.SComment.Where(c => c.Songs_Id == item.Id).ToList();
                foreach (var item2 in vm2.SComment)
                {
                    item2.User = context.Users.Where(u => u.UserName == item2.Users_Id).FirstOrDefault();
                }
                vm.Add(vm2);
            }

            context.SaveChanges();
            return View("Details", vm);
        }
    }
}
