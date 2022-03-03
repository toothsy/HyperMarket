using HyperMarket.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.DB.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(int id);
        void SaveUser(User user);
        void DeleteUser(int id);
    }
}
