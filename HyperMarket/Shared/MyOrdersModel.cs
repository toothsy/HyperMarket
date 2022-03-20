using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.ViewModels
{
    public class MyOrdersModel
    {
        public int OrderId { get; set; }
        public string BusinessName { get; set; }

        public int OrderCredits { get; set; }

        public int TotalAmount { get; set; }
    }
}
