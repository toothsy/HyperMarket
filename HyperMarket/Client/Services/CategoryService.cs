using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Client.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Category>> GetAllCategory()
        {
            //var category = await _httpClient.GetFromJsonAsync<List<String>>($"/api/category/all");
            //return category;
            return await _httpClient.GetFromJsonAsync<List<Category>>($"api/category");
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _httpClient.GetFromJsonAsync<Category>($"/api/category/{id}");
            return category;
        }

        public async Task<Category> GetIdByCategory(string category)
        {
            var loc = await _httpClient.GetFromJsonAsync<Category>($"/api/Category/{category}");
            return loc;
        }
    }
}
