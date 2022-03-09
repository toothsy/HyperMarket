using HyperMarket.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.Data.Interfaces
{
     public class OrderService : IOrderService
        {
            private readonly HttpClient _httpClient;

            public OrderService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }


            public async Task<Order> GetOrderById(int id)
            {
                var order1 = await _httpClient.GetFromJsonAsync<Order>($"/api/order/{id}");
                return order1;
            }


            public async Task<List<Order>> GetOrders()
            {
                var order1 =  await _httpClient.GetFromJsonAsync<List<Order>>($"api/order");
                return order1;   
                
            }
        }
    
}
