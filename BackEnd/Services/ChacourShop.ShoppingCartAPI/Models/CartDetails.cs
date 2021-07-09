using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChacourShop.ShoppingCartAPI.Models
{
    public class CartDetails
    {
        public Guid CartDetailsId { get; set; }
        public Guid CartHeaderId { get; set; }
        [ForeignKey("CartHeaderId")]
        public virtual CartHeader CartHeader { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public int Count { get; set; }
    }
}
