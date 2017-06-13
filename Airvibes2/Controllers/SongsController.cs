using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Airvibes2.Models;
using Microsoft.AspNet.Identity;

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

        [HttpPost]
        public ActionResult AddItemToCart(ShoppingCartItem cartitem)
        {
            string userid = User.Identity.GetUserId();
            List<ShoppingCartItem> cart = new List<ShoppingCartItem>();
            cart = context.ShoppingCart.Where(a => a.SongsId == cartitem.SongsId).ToList();
            if (cart.Count == 0)
            {
                if (context.ShoppingCart.Count() != 0)
                {
                    cartitem.Id = context.ShoppingCart.Count() + 1;
                    cartitem.MemberId = userid;
                    context.ShoppingCart.Add(cartitem);
                }
                else
                {
                    cartitem.Id = 1;
                    cartitem.MemberId = userid;
                    context.ShoppingCart.Add(cartitem);
                }
                context.SaveChanges();
            }            
            RedirectToAction("Details", "Records", context.Songs.Where(s => s.Id == cartitem.SongsId).First().Records_Id);
            return View();
        }
    }
}
