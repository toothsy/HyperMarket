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

        public async Task<CustomerDetail> UpdateUser(CustomerDetail c1)
        {
            c1.User = new User { UserName = "Hello", EmailId = "lucky@gmail.com", Password = "Hello123", ReferredBy = "Hello1234" };

            var response = await _httpClient.PostAsJsonAsync<CustomerDetail>($"api/customerdetail/UpdateUser", c1);

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
