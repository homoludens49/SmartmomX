using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smartmom.Models;
using Smartmom.ViewModels;
using System.Data.Entity;


namespace Smartmom.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        private ApplicationDbContext _context;
        public ItemController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {

            var items = _context.Items.Include(m => m.Brand).ToList();
            return View(items);
        }

        public ActionResult Details(int id)
        {
            var items = _context.Items.Include(m => m.Brand).SingleOrDefault(m => m.ItemId == id);

            if (items == null)
                return HttpNotFound();

            return View(items);



        }

        private IEnumerable<Item> GetItem()
        {
            return new List<Item>
            {
                new Item { ItemId = 1, Name = "Alilo" },
                new Item { ItemId = 2, Name = "Zazu" }
            };
        }
    }
}