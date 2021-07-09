using ChacourShop.MessageBus;
using System;

namespace ChacourShop.PaymentAPI.Messages
{
    public class UpdatePaymentResultMessage : BaseMessage
    {
        public Guid OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
