using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Smartmom.Models;

namespace Smartmom.ViewModels
{
    public class RandomItemViewModel
    {
        public Models.Item Item { get; set; }
        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }
    }
}