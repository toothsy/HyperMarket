using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
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


            public async Task<List<Order>> GetOrderById(int id)
            {
                var order1 = await _httpClient.GetFromJsonAsync<List<Order>>($"/api/order/{id}");
                return order1;
            }


            public async Task<List<Order>> GetOrders()
            {
                var order1 =  await _httpClient.GetFromJsonAsync<List<Order>>($"api/order");
                return order1;   
                
            }

            public async void CreateOrder(OrderModel order)
            {
                var test = new HttpResponseMessage();
                test = await _httpClient.PostAsJsonAsync($"api/order", order);
            }
        }
    
}
