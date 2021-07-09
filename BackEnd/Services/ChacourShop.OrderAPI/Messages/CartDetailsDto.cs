using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChacourShop.OrderAPI.Messages
{
    public class CartDetailsDto
    {
        public Guid CartDetailsId { get; set; }
        public Guid CartHeaderId { get; set; }
        public Guid ProductId { get; set; }
        public virtual ProductDto Product { get; set; }
        public int Count { get; set; }
    }
}
