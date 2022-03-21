using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperMarket.DB.Models;
using HyperMarket.ViewModels;

namespace HyperMarket.Data.Interfaces
{
    public interface IUserRole
    {
        Task<UserRole> UserRoleUpdate(UserRole userRole);
        Task<List<UserRole>> GetAllUser();
        Task DeleteUserRole(int id);

    }
}
