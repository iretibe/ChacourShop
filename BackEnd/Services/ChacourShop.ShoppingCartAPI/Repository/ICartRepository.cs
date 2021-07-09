using ChacourShop.ShoppingCartAPI.Models;
using System;
using System.Threading.Tasks;

namespace ChacourShop.ShoppingCartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartDto> GetCartByUserId(string userId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> RemoveFromCart(Guid cartDetailsId);
        Task<bool> ApplyCoupon(string userId, string couponCode);
        Task<bool> RemoveCoupon(string userId);
        Task<bool> ClearCart(string userId);
    }
}
