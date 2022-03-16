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
        public async Task<SubCategory> GetSubCategoryById(int id)
        {
            var subcatgory = await _httpClient.GetFromJsonAsync<SubCategory>($"/api/subcatgory/{id}");
            return subcatgory;
        }

        public async Task<SubCategory> GetSubCategoryIdByName(string SubCategory)
        {
            var loc = await _httpClient.GetFromJsonAsync<SubCategory>($"/api/Category/{SubCategory}");
            return loc;
        }
    }
}
