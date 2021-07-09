using ChacourShop.UI.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChacourShop.UI.Services
{
    public class CartService : BaseService, ICartService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CartService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> AddToCartAsync<T>(CartDto cartDto, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.POST,
                Data = cartDto,
                Url = ServiceProvider.ShoppingCartAPIBase + "/api/cart/AddCart",
                AccessToken = token
            });
        }

        public async Task<T> ApplyCoupon<T>(CartDto cartDto, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.POST,
                Data = cartDto,
                Url = ServiceProvider.ShoppingCartAPIBase + "/api/cart/ApplyCoupon",
                AccessToken = token
            });
        }

        public async Task<T> Checkout<T>(CartHeaderDto cartHeader, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.POST,
                Data = cartHeader,
                Url = ServiceProvider.ShoppingCartAPIBase + "/api/cart/checkout",
                AccessToken = token
            });
        }

        public async Task<T> GetCartByUserIdAsnyc<T>(string userId, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.GET,
                Url = ServiceProvider.ShoppingCartAPIBase + "/api/cart/GetCart/" + userId,
                AccessToken = token
            });
        }

        public async Task<T> RemoveCoupon<T>(string userId, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.POST,
                Data = userId,
                Url = ServiceProvider.ShoppingCartAPIBase + "/api/cart/RemoveCoupon",
                AccessToken = token
            });
        }

        public async Task<T> RemoveFromCartAsync<T>(Guid cartId, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.POST,
                Data = cartId,
                Url = ServiceProvider.ShoppingCartAPIBase + "/api/cart/RemoveCart",
                AccessToken = token
            });
        }

        public async Task<T> UpdateCartAsync<T>(CartDto cartDto, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ServiceProvider.ApiType.POST,
                Data = cartDto,
                Url = ServiceProvider.ShoppingCartAPIBase + "/api/cart/UpdateCart",
                AccessToken = token
            });
        }
    }
}
