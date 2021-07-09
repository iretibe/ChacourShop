using ChacourShop.MessageBus;

namespace ChacourShop.PaymentAPI.RabbitMQSender
{
    public interface IRabbitMQPaymentMessageSender
    {
        void SendMessage(BaseMessage baseMessage);
    }
}
