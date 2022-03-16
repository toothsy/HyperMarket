using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
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

        public async Task<List<BusinessDetail>> GetBusinesses()
        {
            return await _httpClient.GetFromJsonAsync<List<BusinessDetail>>($"api/BusinessDetail/GetBusinesses");
        }

        public async Task<BusinessDetail> GetBusinessById(int id)
        {
            var businessDetail = await _httpClient.GetFromJsonAsync<BusinessDetail>($"/api/BusinessDetail/GetBusinessById/{id}");
            return businessDetail;
        }


        public async void SaveBusiness(ListBusinessModel business)
        {
            var test = new HttpResponseMessage();
            try
            {
                test = await _httpClient.PostAsJsonAsync($"/api/businessdetail/SaveBusiness", business);
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

        public async Task<BusinessDetail> UpdateBusiness(BusinessDetail business)
        {
            business.User = new User { EmailId = "asd@gmail.com", UserName = "test",Password="abcde12345",ReferredBy ="abcde" };

            business.Location = new Location { LocationName="Delhi",IsLocationActive = true };
            var response = await _httpClient.PostAsJsonAsync<BusinessDetail>($"api/businessdetail/UpdateBusiness", business);

            return await response.Content.ReadFromJsonAsync<BusinessDetail>();
        }
    }
}
