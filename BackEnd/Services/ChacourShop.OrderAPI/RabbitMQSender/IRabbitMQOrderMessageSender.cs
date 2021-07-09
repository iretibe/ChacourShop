using ChacourShop.MessageBus;
using System;

namespace ChacourShop.OrderAPI.RabbitMQSender
{
    public interface IRabbitMQOrderMessageSender
    {
        void SendMessage(BaseMessage baseMessage, String queueName);
    }
}
