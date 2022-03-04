using HyperMarket.Data;
using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.DB.Interfaces
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<User> GetUserById(int id)
        {
            var user =await _httpClient.GetFromJsonAsync<User>($"/api/user/{id}");
            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>($"api/user");
        }

        public async void SaveUser(User user)
        {
            var test = await _httpClient.PostAsJsonAsync ($"api/user/",user);

            Console.WriteLine(test);
        }

        //public void DeleteUser(int id)
        //{
        //    var customer = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
        //    if (customer != null)
        //    {
        //        _dbContext.Users.Remove(customer);
        //        _dbContext.SaveChanges();
        //    }
        //}
    }
}
