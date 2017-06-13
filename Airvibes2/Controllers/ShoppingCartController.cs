using Airvibes2.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airvibes2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cartlist = db.ShoppingCart.ToList().OrderBy(m => m.Id);
            return View(cartlist);
        }

        [HttpPost]
        public ActionResult DeleteItemFromCart(ShoppingCartItem cartItem)
        {
            ShoppingCartItem cartitemToDelete = db.ShoppingCart.First(c => c.SongsId == cartItem.SongsId);
            db.ShoppingCart.Remove(cartitemToDelete);
            db.SaveChanges();
            Response.Redirect(Request.RawUrl);
            return Redirect("Index");
        }

        [HttpPost]
        public ActionResult ValidateCart()
        {
            string userId = User.Identity.GetUserId();
            ApplicationUser userToModify = db.Users.First(a => a.Id == userId);
            foreach(var item in db.ShoppingCart)
            {
                if(userToModify != null)
                {
                    if(userToModify.OwnedSongs == null)
                    {
                        userToModify.OwnedSongs = new List<int>();
                        userToModify.OwnedSongs.Add(item.SongsId);
                        userToModify.ownedSongs.Add(db.Songs.First(s => s.Id == item.SongsId));
                        db.ShoppingCart.Remove(item);
                    }
                    else if (!userToModify.ownedSongs.Contains(db.Songs.First(s => s.Id == item.SongsId)))
                    {
                        userToModify.OwnedSongs.Add(item.SongsId);
                        userToModify.ownedSongs.Add(db.Songs.First(s => s.Id == item.SongsId));
                        db.ShoppingCart.Remove(item);
                    }
                    else
                    {
                        db.ShoppingCart.Remove(item);
                    }
                }                
            }
            db.SaveChanges();
            return Redirect("Index");            
        }
    }
}