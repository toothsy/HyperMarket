using HyperMarket.DB.Models;

namespace HyperMarket.Client.Services
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryById(int id);
        Task<List<Category>> GetAllCategory();
        Task<Category> GetIdByCategory(string category);
    }
}
