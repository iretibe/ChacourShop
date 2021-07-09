using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChacourShop.ShoppingCartAPI.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ProductImage { get; set; }
    }
}
