using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
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
        Task<List<Product>> GetProductById(int id);
        void SaveProduct(AddProductModel prod);

        Task DeleteProduct(int id);
    }
}
