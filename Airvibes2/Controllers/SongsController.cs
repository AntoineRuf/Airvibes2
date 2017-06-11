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
    public class SongsController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        // GET: Songs
        public ActionResult Index()
        {
            return View(context.Songs.ToList());
        }

        [HttpPost]
        public ActionResult Rate(Songs song)
        {
            Songs newSong = context.Songs.Where(s => s.Id == song.Id).FirstOrDefault();
            song.Mark = (newSong.Mark * newSong.NbrMarks + song.Mark) / (newSong.NbrMarks + 1);
            newSong.NbrMarks++;
            context.Entry(newSong).State = EntityState.Modified;
            context.SaveChanges();

            int Records_Id = context.Songs.Where(s => s.Id == song.Id).First().Records_Id;
            RedirectToAction("Details", "Records", Records_Id);

            return View();
        }
    }
}
