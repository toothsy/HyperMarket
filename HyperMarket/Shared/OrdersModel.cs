using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.ViewModels
{
    public class OrdersModel
    {
        public int UserId { get; set; } 

        public string BusinessName { get; set; }
        public int ProductId { get; set; }
        public int MyOrderCredits { get; set; }

        public int PaymentId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
    }
}
