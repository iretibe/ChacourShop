using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChacourShop.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int StockLevel { get; set; }
    }
}
