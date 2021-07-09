using System;

namespace ChacourShop.ShoppingCartAPI.Models
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ProductImage { get; set; }
    }
}
