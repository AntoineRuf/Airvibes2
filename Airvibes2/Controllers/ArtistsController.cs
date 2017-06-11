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
    public class ArtistsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Records
        public ActionResult Index()
        {
            var artists = db.Artists.ToList().OrderBy(m => m.Id);
            return View(artists);
        }

        // GET: Records/Details/5
        public ActionResult Details(int? id)
        {
            var context = new ApplicationDbContext();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artists artists = db.Artists.Find(id);

            if (artists == null)
            {
                return HttpNotFound();
            }
            ViewBag.Photo = artists.Photo;
            ViewBag.Name = artists.Name;
            ViewBag.Bio = artists.Bio;
            artists.Records = context.Records.Where(r => r.Artists_Id == artists.Id).ToList();
            context.SaveChanges();
            return View(artists);
        }
    }
}
