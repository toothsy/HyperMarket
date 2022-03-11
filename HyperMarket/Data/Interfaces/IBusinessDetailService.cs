using HyperMarket.DB.Models;

namespace HyperMarket.Data.Interfaces
{
    public interface IBusinessDetailService
    {
        Task<List<BusinessDetail>> GetBusinesses();
        Task<BusinessDetail> GetBusinessById(int id);
        void SaveBusiness(BusinessDetail businessDetail);
        Task<BusinessDetail> UpdateBusiness(BusinessDetail Business);
    }
}
