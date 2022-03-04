using HyperMarket.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using HyperMarket.Data;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.Data.Interfaces
{
    public class ProductService: IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly ApplicationDbContext _context;

        public ProductService(HttpClient httpClient,ApplicationDbContext context)
        {
            _httpClient = httpClient;
            _context= context;
        }

        //public List<User> GetUsers()
        //{
        //    //return _dbContext.Users.ToList();
        //}

        public async Task<Product> GetProductById(int id)
        {
            var prod = await _httpClient.GetFromJsonAsync<Product>($"/api/product/{id}");
            return prod;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>($"api/product");
        }

        public void SaveProduct(Product prod)
        {
            //_context.Products.Add(prod);
            //_context.SaveChanges();
        }
        //public void SaveUser(User user)
        //{
        //    if (user.UserId == 0) _dbContext.Users.Add(user);
        //    else _dbContext.Users.Update(user);
        //    _dbContext.SaveChanges();
        //}
    }
}
