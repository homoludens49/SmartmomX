using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Smartmom.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string BrandName { get; set; }
    }
}