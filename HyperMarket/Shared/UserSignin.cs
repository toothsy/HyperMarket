using System.ComponentModel.DataAnnotations;

namespace HyperMarket.ViewModels
{
    public class UserSignin
    {
        [Required(ErrorMessage = "Please enter an Email Address."), EmailAddress]
        public string Email { get; set; }
        public OTPValidate OTPValidate { get; set; }
    }
}
