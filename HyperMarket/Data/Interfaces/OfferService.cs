using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    public class OfferService : IOffer
    {
        private readonly HttpClient _httpClient;
        public OfferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Product>> GetProductsByBusinessID(int id){

            var products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/offer/{id}");

            return products;
        }
    }
}
