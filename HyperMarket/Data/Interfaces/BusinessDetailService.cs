using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    public class BusinessDetailService:IBusinessDetailService
    {
        private readonly HttpClient _httpClient;

        public BusinessDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<User> GetBusinessById(int id)
        {
            var user = await _httpClient.GetFromJsonAsync<User>($"/api/user/{id}");
            return user;
        }

        public async Task<List<User>> GetBusiness()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>($"api/user");
        }

        public async void SaveBusiness(User user)
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
        public async void SaveBusiness(BusinessDetail business)
        {
            var test = new HttpResponseMessage();
            try
            {

                test = await _httpClient.PostAsJsonAsync($"api/user/", business);
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
    }

}
