using ChacourShop.CouponAPI.Models;
using System.Threading.Tasks;

namespace ChacourShop.CouponAPI.Respository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
