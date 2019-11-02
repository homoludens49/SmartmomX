using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smartmom.Models;

namespace Smartmom.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Random()
        {
            var item = new Item() { Name = "Alilo" };
           
          //  return View(item);
            return HttpNotFound();
        }
    }
}