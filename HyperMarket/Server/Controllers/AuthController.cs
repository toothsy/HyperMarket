using HyperMarket.Helpers;
using HyperMarket.DB.Models;
using HyperMarket.MailClient;
using HyperMarket.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Web;

namespace HyperMarket.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Signup(UserSignup request)
        {
            var isValidOtp = await ValidateOTP(request.OTPValidate);
            var isReferred = await _authRepo.ValidateReferral(request.ReferralCode);

            User userObject = new User()
            {
                UserName = request.Username,
                Password = String.Empty,
                EmailId = request.Email,
                ReferredBy = String.Empty,
                CreatedBy = -1,
                UpdatedBy = -1,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            if (isValidOtp.Success)
            {
                var response = await _authRepo.Signup(userObject);
                if (!response.Success)
                {
                    return BadRequest(response);
                }
                
                CustomerDetail cd = new CustomerDetail()
                {
                    User = userObject,
                    UserId = userObject.UserId,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    ReferralCode = userObject.UserName + "10",
                    MyCredits = 10
                };
                if (isReferred.Success)
                {
                    cd.MyCredits = cd.MyCredits + 100;
                }
                if (!(await _authRepo.createCustomer(cd)))
                    return BadRequest(response);
                    
                return Ok(response);
            }
            else
            {
                return BadRequest(isValidOtp);
            }
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Signin(UserSignin request)
        {
            var isValidOtp = await ValidateOTP(request.OTPValidate);
            if (isValidOtp.Success)
            {
                var response = await _authRepo.Signin(request.Email);
                if (!response.Success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            else
            {
                return BadRequest(isValidOtp);
            }
            
        }

        [HttpPost("getotp")]
        public async Task<IActionResult> GetOTP(UserSignin user)
        {
            var response = new ServiceResponse<string>();

            var emailClient = new EmailClient();
            var otp = emailClient.GenerateOTP();
            var encryptedOtp = EncryptionHelper.Encrypt($"{otp}${DateTime.UtcNow.ToString("yyyyMMddHHmmss")}");
            bool emailSuccess = emailClient.SendEmail(user.Email, "code6737@gmail.com", "HyperMarket@4", "Team HyperMarket");

            if (!emailSuccess)
            {
                response.Success = false;
                response.Message = "Unable to send OTP via mail.";
                return BadRequest(response);
            }

            response.Data = encryptedOtp;
            response.Message = "OTP sent successfully via mail.";
            return Ok(response);
        }

        private async Task<ServiceResponse<string>> ValidateOTP(OTPValidate otpValidate)
        {
            var response = new ServiceResponse<string>();

            var decryptedOtpTime = EncryptionHelper.Decrypt(HttpUtility.UrlDecode(otpValidate.EncryptedActualOTPTimestamp.Trim('"')));
            var prevDate = DateTime.ParseExact(decryptedOtpTime.Split('$')[1], "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            var currentDate = DateTime.UtcNow;
            var timespan = currentDate.Subtract(prevDate);
            if (timespan.Minutes > 2 || !otpValidate.UserOTP.Equals(decryptedOtpTime.Split('$')[0]))
            {
                response.Success = false;
                response.Message = "Invalid OTP";
                return response;
            }

            response.Message = "Valid OTP";
            return response;
        }

        
    }
}
