using System.ComponentModel.DataAnnotations;

namespace HyperMarket.ViewModels
{
    public class UserOTP
    {
        [Required, RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit OTP")]
        public string OTP { get; set; }
    }
}
