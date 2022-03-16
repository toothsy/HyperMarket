using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Client.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly HttpClient _httpClient;
        public SubCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<SubCategory>> GetAllSubCategory()
        {
            var subcategory = await _httpClient.GetFromJsonAsync<List<SubCategory>>($"api/subcategory");
            return subcategory;
        }

        public Task<SubCategory> GetSubCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategory> GetSubCategoryIdByName(string location)
        {
            throw new NotImplementedException();
        }
    }
}
