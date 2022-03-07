using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    internal class BlogService : IBlogsService
    {
        private readonly HttpClient _httpClient;

        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Blog> GetBlogById(int id)
        {
            var blog = await _httpClient.GetFromJsonAsync<Blog>($"/api/blog/{id}");
            return blog;
        }

        public Task<List<Blog>> GetBlogMeta()
        {
            throw new NotImplementedException();
        }

        public void SaveBlog(Blog bl)
        {
            throw new NotImplementedException();
        }
    }
}
