using HyperMarket.Data;
using HyperMarket.DB.Models;
using System.Net.Http.Json;
using HyperMarket.ViewModels;

namespace HyperMarket.Data.Interfaces
{
    public class CustomerDetailService : ICustomerDetailService
    {
        private readonly HttpClient _httpClient;

        public CustomerDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CustomerDetail>> GetCustomerDetail()
        {
            return await _httpClient.GetFromJsonAsync<List<CustomerDetail>>($"api/customerdetail/GetCustomerDetail");
        }

        public async Task<CustomerDetail> GetCustomerDetailById(int id)
        {
            var customer = await _httpClient.GetFromJsonAsync<CustomerDetail>($"/api/customerdetail/GetCustomerDetailById/{id}");
            return customer;
        }

        public async void SaveUser(CustomerDetail c)
        {
            var res = await _httpClient.PostAsJsonAsync("api/CustomerDetail/SaveUser", c);
        }

        public async Task<CustomerDetail> UpdateUser(CustomerDetail customer1)
        {
            customer1.User = new User { UserName = "Hello", EmailId = "lucky@gmail.com", Password = "Hello123", ReferredBy = "Hello1234" };

            var response = await _httpClient.PostAsJsonAsync<CustomerDetail>($"api/customerdetail/UpdateUser", customer1);

            return await response.Content.ReadFromJsonAsync<CustomerDetail>();
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
