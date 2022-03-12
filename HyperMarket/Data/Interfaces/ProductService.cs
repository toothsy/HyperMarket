using HyperMarket.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using HyperMarket.Data;
using System.Text;
using System.Threading.Tasks;
using HyperMarket.ViewModels;

namespace HyperMarket.Data.Interfaces
{
    public class ProductService: IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
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

        public async void SaveProduct(AddProductModel prod)
        {
            var test = new HttpResponseMessage();
            try
            {
                test = await _httpClient.PostAsJsonAsync($"/api/product/", prod);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine(test);
            }
        }
        //public void SaveUser(User user)
        //{
        //    if (user.UserId == 0) _dbContext.Users.Add(user);
        //    else _dbContext.Users.Update(user);
        //    _dbContext.SaveChanges();
        //}
    }
}
