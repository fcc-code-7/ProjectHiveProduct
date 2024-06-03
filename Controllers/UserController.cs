using ProWeb.Data;
using ProWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProWeb.Controllers
{
    [Authorize(Roles = "User")]
    [Route("User/[Controller Name]")]
    public class UserController : Controller
    {
        private ProductContext db = new ProductContext();

        // GET: Product
       
        public ActionResult Index()
        {
            var products = db.Products.ToList();
            return View(products);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    }
}