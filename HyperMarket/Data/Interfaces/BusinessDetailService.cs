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


        public async void SaveBusiness(BusinessDetail business)
        {
            var test = new HttpResponseMessage();
            try
            {

                test = await _httpClient.PostAsJsonAsync($"api/businessdetail/", business);
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
