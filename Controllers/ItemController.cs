using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smartmom.Models;
using Smartmom.ViewModels;


namespace Smartmom.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ViewResult Index()
        {
            var items = GetItem();

            return View(items);
        }

        private IEnumerable<Item> GetItem()
        {
            return new List<Item>
            {
                new Item { Id = 1, Name = "Alilo" },
                new Item { Id = 2, Name = "Zazu" }
            };
        }
    }
}