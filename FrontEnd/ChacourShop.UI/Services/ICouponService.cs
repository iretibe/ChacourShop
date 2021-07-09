using System.Threading.Tasks;

namespace ChacourShop.UI.Services
{
    public interface ICouponService
    {
        Task<T> GetCoupon<T>(string couponCode, string token = null);
    }
}
