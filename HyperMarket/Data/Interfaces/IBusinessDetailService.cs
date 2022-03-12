using HyperMarket.DB.Models;
using HyperMarket.ViewModels;

namespace HyperMarket.Data.Interfaces
{
    public interface IBusinessDetailService
    {
        Task<List<BusinessDetail>> GetBusinesses();
        Task<BusinessDetail> GetBusinessById(int id);
        void SaveBusiness(ListBusinessModel business);
        Task<BusinessDetail> UpdateBusiness(BusinessDetail business);
    }
}
