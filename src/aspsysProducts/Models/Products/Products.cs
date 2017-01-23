using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aspsysProducts.Models.Products
{
    public class Products

    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        [Display(Name = "Thumbnail Url")]
        public string ThumbnailUrl { get; set; }
        public string Url { get; set; }
        [Display(Name = "Starting Price")]
        public decimal StartingPrice { get; set; }
        public string Description { get; set; }
    }
}
