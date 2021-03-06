using HyperMarket.DB.Models;
using HyperMarket.ViewModels;

namespace HyperMarket.Server
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Signup(User user);
        Task<ServiceResponse<string>> Signin(string email);
        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> ValidateReferral(string referral);
        Task<bool> createCustomer(CustomerDetail cd);
    }
}
