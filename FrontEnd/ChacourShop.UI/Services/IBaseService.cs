using ChacourShop.UI.Models;
using System;
using System.Threading.Tasks;

namespace ChacourShop.UI.Services
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
