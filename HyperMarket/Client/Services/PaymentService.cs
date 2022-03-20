using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _httpClient;

        public PaymentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async void SavePaymentDetails(PaymentModel bill)
        {
            var test = new HttpResponseMessage();
            try
            {
                test = await _httpClient.PostAsJsonAsync($"/api/payment", bill);
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

        public async Task<Payment> GetCurrentPayment()
        {
            var pay = await _httpClient.GetFromJsonAsync<Payment>($"/api/payment");
            return pay;
        }

        public async Task<Payment> GetPaymentById(int id)
        {
            var pay = await _httpClient.GetFromJsonAsync<Payment>($"/api/payment/{id}");
            return pay;
        }

    }
}
