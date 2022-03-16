using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.Data.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrders();
        Task<Order> GetOrderById(int id);
        void CreateOrder(OrderModel order);
    }
}
