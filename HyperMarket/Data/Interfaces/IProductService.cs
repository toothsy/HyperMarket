using HyperMarket.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.Data.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        void SaveProduct(Product prod);
    }
}
