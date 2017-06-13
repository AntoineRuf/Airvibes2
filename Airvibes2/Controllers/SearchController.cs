using Airvibes2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airvibes2.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Search

        public ActionResult Index(string searchString)
        {
            var context = new ApplicationDbContext();
            string searchCriteria = Request.Form["criteria"];
            if (searchString != null)
            {
                if(searchCriteria == "Artiste")
                {
                    List<Artists> artists = db.Artists.Where(s => s.Name.Contains(searchString)).ToList();
                    return PartialView("ArtistsResult", artists);
                }
                else if(searchCriteria == "Album")
                {
                    Records records = (Records)db.Records.Where(s => s.Title.Contains(searchString));
                    return PartialView("RecordsResult",records);
                }
                else if(searchCriteria == "Titre")
                {
                    Songs songs = (Songs)db.Songs.Where(s => s.Title.Contains(searchString));
                    return PartialView("SongsResult",songs);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}