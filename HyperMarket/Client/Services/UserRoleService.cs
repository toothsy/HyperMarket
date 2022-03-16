using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    public class UserRoleService : IUserRole
    {
        private readonly HttpClient _httpClient;

        public UserRoleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<UserRole> UserRoleUpdate(UserRole userRole){
            //userRole.User = new User { UserName = "Hello", EmailId = "lucky@gmail.com", Password = "Hello123", ReferredBy = "Hello1234" };

            var response = await _httpClient.PostAsJsonAsync<UserRole>($"api/UserRoleUpdate", userRole);

            return await response.Content.ReadFromJsonAsync<UserRole>();
        }
    }
}
