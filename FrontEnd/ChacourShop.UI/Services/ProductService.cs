using ChacourShop.UI.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChacourShop.UI.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.POST,
                Data = productDto,
                Url = ServiceProvider.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }

        public async Task<T> DeleteProductAsync<T>(Guid id, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.DELETE,
                Url = ServiceProvider.ProductAPIBase + "/api/products/" + id,
                AccessToken = token
            });
        }

        public async Task<T> GetAllProductsAsync<T>(string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.GET,
                Url = ServiceProvider.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }

        public async Task<T> GetProductByIdAsync<T>(Guid id, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.GET,
                Url = ServiceProvider.ProductAPIBase + "/api/products/" + id,
                AccessToken = token
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto, string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.PUT,
                Data = productDto,
                Url = ServiceProvider.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }
    }
}
