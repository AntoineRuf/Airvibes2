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
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchResult(string searchString)
        {
            var context = new ApplicationDbContext();
            SearchModel res = new SearchModel();
            res.Artists = db.Artists.Where(a => a.Name.ToLower().Contains(searchString.ToLower())).ToList();
            res.Records = db.Records.Where(a => a.Title.ToLower().Contains(searchString.ToLower())).ToList();
            res.Songs = db.Songs.Where(a => a.Title.ToLower().Contains(searchString.ToLower())).ToList();
            return View("SearchResults",res);
        }
    }
}