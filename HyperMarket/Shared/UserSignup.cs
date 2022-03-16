using System.ComponentModel.DataAnnotations;

namespace HyperMarket.ViewModels
{
    public class UserSignup
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(30, ErrorMessage = "Username must be atleast 8 characters long.", MinimumLength =8)]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReferralCode { get; set; }

        public OTPValidate OTPValidate { get; set; }
    }
}
