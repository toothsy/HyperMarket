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

        //public List<User> GetUsers()
        //{
        //    //return _dbContext.Users.ToList();
        //}

        public async Task<User> GetUserById(int id)
        {
            var user =await _httpClient.GetFromJsonAsync<User>($"/api/user/{id}");
            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>($"api/user");
        }

        //public void SaveUser(User user)
        //{
        //    if (user.UserId == 0) _dbContext.Users.Add(user);
        //    else _dbContext.Users.Update(user);
        //    _dbContext.SaveChanges();
        //}

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
