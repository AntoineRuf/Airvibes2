using Airvibes2.Models;
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
            return View();
        }
    }
}