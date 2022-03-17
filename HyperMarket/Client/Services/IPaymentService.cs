using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperMarket.ViewModels;
using HyperMarket.DB.Models;

namespace HyperMarket.Data.Interfaces
{
    public interface IPaymentService
    {
        Task<Payment> GetCurrentPayment();
        void SavePaymentDetails(PaymentModel business);

    }
}
