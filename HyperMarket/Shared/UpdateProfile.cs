
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HyperMarket.ViewModels
{
    public class UpdateProfile
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReferralCode { get; set; }
     //   public int MyCredits { get; set; }

    }
}
