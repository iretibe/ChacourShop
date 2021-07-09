using ChacourShop.ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChacourShop.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(Guid productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(Guid productId);
    }
}
