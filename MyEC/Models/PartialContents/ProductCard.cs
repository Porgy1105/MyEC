using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEC.Models.PartialContents
{
    public class ProductCard
    {
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
    }
}