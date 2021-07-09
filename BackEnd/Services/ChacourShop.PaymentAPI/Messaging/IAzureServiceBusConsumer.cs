using System.Threading.Tasks;

namespace ChacourShop.PaymentAPI.Messaging
{
    public interface IAzureServiceBusConsumer
    {
        Task Start();
        Task Stop();
    }
}
