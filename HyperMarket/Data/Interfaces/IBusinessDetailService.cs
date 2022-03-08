using HyperMarket.DB.Models;

namespace HyperMarket.Data.Interfaces
{
    public interface IBusinessDetailService
    {
        Task<List<BusinessDetail>> GetBusinesses();
        void SaveBusiness(BusinessDetail businessDetail);
    }
}
