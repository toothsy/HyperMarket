using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HyperMarket.DB.Models;


using HyperMarket.Data;
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


        public async Task<Payment> GetPaymentById(int id)
        {
            var pay = await _httpClient.GetFromJsonAsync<Payment>($"/api/payment/{id}");
            return pay;
        }
    }
}
