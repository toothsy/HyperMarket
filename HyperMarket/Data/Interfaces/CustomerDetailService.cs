using HyperMarket.Data;
using HyperMarket.DB.Models;
using System.Net.Http.Json;

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
            return await _httpClient.GetFromJsonAsync<List<CustomerDetail>>($"api/customerdetail");
        }

        public async Task<CustomerDetail> GetCustomerDetailById(int id)
        {
            return await _httpClient.GetFromJsonAsync<CustomerDetail>($"api/customerdetail/{id}");
        }

        public async Task<CustomerDetail> UpdateUser(CustomerDetail customerDetail)
        {
            var response = await _httpClient.PutAsJsonAsync<CustomerDetail>($"/api/customerdetail/{customerDetail.UserId}", customerDetail);

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
