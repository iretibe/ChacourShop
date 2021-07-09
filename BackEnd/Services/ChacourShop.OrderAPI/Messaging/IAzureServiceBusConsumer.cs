using System.Threading.Tasks;

namespace ChacourShop.OrderAPI.Messaging
{
    public interface IAzureServiceBusConsumer
    {
        Task Start();
        Task Stop();
    }
}
