using ChacourShop.UI.Models;
using System;
using System.Threading.Tasks;

namespace ChacourShop.UI.Services
{
    public interface ICartService
    {
        Task<T> GetCartByUserIdAsnyc<T>(string userId, string token = null);
        Task<T> AddToCartAsync<T>(CartDto cartDto, string token = null);
        Task<T> UpdateCartAsync<T>(CartDto cartDto, string token = null);
        Task<T> RemoveFromCartAsync<T>(Guid cartId, string token = null);
        Task<T> ApplyCoupon<T>(CartDto cartDto, string token = null);
        Task<T> RemoveCoupon<T>(string userId, string token = null);

        Task<T> Checkout<T>(CartHeaderDto cartHeader, string token = null);
    }
}
