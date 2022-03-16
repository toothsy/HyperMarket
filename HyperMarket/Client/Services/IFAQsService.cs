using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperMarket.DB.Models;


namespace HyperMarket.Data.Interfaces
{
    public interface IFAQsService
    {
        Task<Faq> GetFaqs(int id);
    }
}
