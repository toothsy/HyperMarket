
using HyperMarket.DB.Models;


namespace HyperMarket.Data.Interfaces
{
    public interface IFAQsService
    {
        Task<List<Faq>> GetAllFaqs();
    }
}
