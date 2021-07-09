using System.Collections.Generic;

namespace ChacourShop.ShoppingCartAPI.Models
{
    public class Cart
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable<CartDetails> CartDetails { get; set; }
    }
}
