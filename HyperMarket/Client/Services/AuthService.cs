using Blazored.LocalStorage;
using HyperMarket.ViewModels;
using System.Net.Http.Json;

namespace HyperMarket.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorageService;

        public AuthService(HttpClient http, ILocalStorageService localStorageService)
        {
            _http = http;
            _localStorageService = localStorageService;
        }

        public async Task<ServiceResponse<string>> GetOTP(UserSignin user)
        {
            var result = await _http.PostAsJsonAsync("api/auth/getotp", user);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<string>> Signin(UserSignin request, UserOTP userOTP)
        {
            string otpInStorage = await _localStorageService.GetItemAsStringAsync("OTP");
            request.OTPValidate = new OTPValidate
            {
                EncryptedActualOTPTimestamp = otpInStorage,
                UserOTP = userOTP.OTP
            };
            var result = await _http.PostAsJsonAsync("api/auth/signin", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Signup(UserSignup request, UserOTP userOTP)
        {
            string otpInStorage = await _localStorageService.GetItemAsStringAsync("OTP");

            request.OTPValidate = new OTPValidate
            {
                EncryptedActualOTPTimestamp = otpInStorage,
                UserOTP = userOTP.OTP
            };
            var result = await _http.PostAsJsonAsync("api/auth/signup", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();

        }
    }
}
