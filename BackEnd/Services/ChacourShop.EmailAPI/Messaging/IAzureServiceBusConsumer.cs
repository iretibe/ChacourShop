using System.Threading.Tasks;

namespace ChacourShop.EmailAPI.Messaging
{
    public interface IAzureServiceBusConsumer
    {
        Task Start();
        Task Stop();
    }
}
