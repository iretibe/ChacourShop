using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChacourShop.OrderAPI.Models
{
    public class OrderDetails
    {
        [Key]
        public Guid OrderDetailsId { get; set; }
        public Guid OrderHeaderId { get; set; }
        [ForeignKey("OrderHeaderId")]
        public virtual OrderHeader OrderHeader { get; set; }
        public Guid ProductId { get; set; }

        public int Count { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}
