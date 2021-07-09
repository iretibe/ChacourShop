using ChacourShop.OrderAPI.Models;
using System;
using System.Threading.Tasks;

namespace ChacourShop.OrderAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader orderHeader);
        Task UpdateOrderPaymentStatus(Guid orderHeaderId, bool paid);
    }
}
