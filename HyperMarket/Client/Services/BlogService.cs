using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _httpClient;

        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Blog> GetBlogById(int id)
        {
            var blog1 = await _httpClient.GetFromJsonAsync<Blog>($"/api/blog/{id}");

            return blog1;
        }

        public async Task<List<Blog>> GetBlog()
        {
            return await _httpClient.GetFromJsonAsync<List<Blog>>($"api/blog");
        }

        public void SaveBlog(Blog bl)
        {
            throw new NotImplementedException();
        }
    }
}