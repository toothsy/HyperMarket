using HyperMarket.ViewModels;

namespace HyperMarket.Client.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Signup(UserSignup request, UserOTP userOTP);
        Task<ServiceResponse<string>> Signin(UserSignin request, UserOTP userOTP);
        Task<ServiceResponse<string>> GetOTP(UserSignin user);
    }
}
