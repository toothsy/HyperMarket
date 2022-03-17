using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.ViewModels
{
    public class OrderModel
    {
        public int UserId { get; set; }
        public int BusinessId { get; set; }
        public int ProductId { get; set; }
        public int MyOrderCredits { get; set; }
        public int PaymentId { get; set; }
    }
}
