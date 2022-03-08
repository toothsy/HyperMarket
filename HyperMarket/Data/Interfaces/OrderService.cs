using HyperMarket.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

//namespace HyperMarket.Data.Interfaces
//{
//    public class OrderService
//    {
//        public class OrderService : IOrderService
//        {
//            private readonly HttpClient _httpClient;

//            public OrderService(HttpClient httpClient)
//            {
//                _httpClient = httpClient;
//            }


//            public async Task<Order> GetOrderById(int id)
//            {
//                var user = await _httpClient.GetFromJsonAsync<Order>($"/api/order/{id}");
//                return user;
//            }


//            public async Task<List<Order>> GetOrders()
//            {
//                await _httpClient.GetFromJsonAsync<List<User>>($"api/order");
//            }
//        }
//    }
//}
