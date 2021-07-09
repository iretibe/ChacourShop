using System;

namespace ChacourShop.OrderAPI.Messages
{
    public class UpdatePaymentResultMessage
    {
        public Guid OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
