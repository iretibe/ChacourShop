using System;
using System.ComponentModel.DataAnnotations;

namespace ChacourShop.UI.Models
{
    public class ProductDto
    {
        public ProductDto()
        {
            Count = 1;
        }

        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int StockLevel { get; set; }

        [Range(1, 100)]
        public int Count { get; set; }
    }
}
