using ChacourShop.ShoppingCartAPI.Models;
using System.Threading.Tasks;

namespace ChacourShop.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
