using System.Threading.Tasks;

namespace ChacourShop.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}
