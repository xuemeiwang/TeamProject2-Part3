using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject2_Part3.Models;

namespace TeamProject2_Part3.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantContext db = new RestaurantContext();

        // GET: /Restaurant
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: /Restaurant/Browse?category=Soup
        public ActionResult Browse(string category)
        {
            if (category == null)
            {
                category = "Soup";
            }

            Category categoryModel = db.Categories.Include("Items").Single(c => c.Name == category);
            return View(categoryModel);
        }

        // GET: /Restaurant/Details/1
        public ActionResult Details(int? id = 1)
        {
            Item item = db.Items.Find(id);
            return View(item);
        }

        //
        // GET: /Restaurant/CategoryMenu
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = db.Categories.ToList();
            return PartialView(categories);
        }
    }
}