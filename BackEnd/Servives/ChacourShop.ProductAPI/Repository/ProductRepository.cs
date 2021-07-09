using AutoMapper;
using ChacourShop.ProductAPI.DbContexts;
using ChacourShop.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChacourShop.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);

            if (product.ProductId != Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                _db.Products.Update(product);
            }
            else
            {
                _db.Products.Add(product);
            }

            await _db.SaveChangesAsync();

            return _mapper.Map<Product, ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(Guid productId)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                
                if (product == null)
                {
                    return false;
                }

                _db.Products.Remove(product);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductById(Guid productId)
        {
            Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productList = await _db.Products.ToListAsync();

            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
