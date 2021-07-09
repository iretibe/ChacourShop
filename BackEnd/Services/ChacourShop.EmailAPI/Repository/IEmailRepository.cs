using ChacourShop.EmailAPI.Messages;
using System.Threading.Tasks;

namespace ChacourShop.EmailAPI.Repository
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
