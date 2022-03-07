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

        //public async Task<CustomerDetail> GetCustomerDetailById(int id)
        //{
        //    return await _httpClient.GetFromJsonAsync<CustomerDetail>($"api/user/{id}");
        //}
        public async void SaveUser(User user)
        {
            var test = new HttpResponseMessage();
            try
            {

                test = await _httpClient.PostAsJsonAsync($"api/user/", user);
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

        public async Task<User> UpdateUser(User user)
        {
            var response = await _httpClient.PutAsJsonAsync<User>($"/api/user/{user.UserId}", user);

            return await response.Content.ReadFromJsonAsync<User>();
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
