using HyperMarket.DB.Models;

namespace HyperMarket.Data.Interfaces
{
    public interface IOffer{
        Task<List<Product>> GetProductsByBusinessID(int id);
    }
}
