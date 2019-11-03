using System;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Smartmom.Models
{
    public class Item
    {
        [Required]
        public int ItemId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Brand Brand { get; set; }
        [Display(Name = "Brand")]
        [Required]
        public byte BrandId { get; set; }
        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate  { get; set; }

        [Required]
        public byte NumberInStock { get; set; }
    }

    //item/random
}