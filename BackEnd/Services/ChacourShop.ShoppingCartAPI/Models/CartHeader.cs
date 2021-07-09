using System;
using System.ComponentModel.DataAnnotations;

namespace ChacourShop.ShoppingCartAPI.Models
{
    public class CartHeader
    {
        [Key]
        public Guid CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
    }
}
