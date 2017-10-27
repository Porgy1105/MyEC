using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEC.Models
{
    public class ProductDetail : Base
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDetailDescription { get; set; }
    }
}