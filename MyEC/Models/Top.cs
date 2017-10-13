using MyEC.Models.PartialContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEC.Models
{
    public class Top:Base
    {

        public ProductCard TopProductCard1 { get; set; } = new ProductCard();
        public ProductCard TopProductCard2 { get; set; } = new ProductCard();
        public ProductCard TopProductCard3 { get; set; } = new ProductCard();

        public Top()
        {
            this.TopProductCard1.ImageUrl = "scissors.jpeg";
            this.TopProductCard1.ProductId = "scissors";
            this.TopProductCard1.ProductName = "ハサミ";
            this.TopProductCard1.ProductDetail = "よく切れるはさみです。";
            this.TopProductCard1.Price = 500;

            this.TopProductCard2.ImageUrl = "hat.jpeg";
            this.TopProductCard2.ProductId = "hat";
            this.TopProductCard2.ProductName = "帽子";
            this.TopProductCard2.ProductDetail = "カッコいい帽子です。";
            this.TopProductCard2.Price = 3000;

            this.TopProductCard3.ImageUrl = "car.jpeg";
            this.TopProductCard3.ProductId = "car";
            this.TopProductCard3.ProductName = "車";
            this.TopProductCard3.ProductDetail = "中古の車です。";
            this.TopProductCard3.Price = 100000;
        }
    }
}