using AutoMapper;
using ChacourShop.CouponAPI.DbContexts;
using ChacourShop.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ChacourShop.CouponAPI.Respository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly ApplicationDbContext _db;
        protected IMapper _mapper;

        public CouponRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CouponDto> GetCouponByCode(string couponCode)
        {
            var couponFromDb = await _db.Coupons.FirstOrDefaultAsync(u => u.CouponCode == couponCode);
            return _mapper.Map<CouponDto>(couponFromDb);
        }
    }
}
