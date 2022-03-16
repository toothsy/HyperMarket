using HyperMarket.DB.Models;

namespace HyperMarket.Client.Services
{
    public interface ISubCategoryService
    {
        Task<SubCategory> GetSubCategoryById(int id);
        Task<List<SubCategory>> GetAllSubCategory();
        Task<SubCategory> GetSubCategoryIdByName(string location);
    }
}
