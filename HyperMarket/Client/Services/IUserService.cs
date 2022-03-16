using HyperMarket.DB.Models;

namespace HyperMarket.DB.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(int id);

        void SaveUser(User user);

        Task<User> UpdateUser(User user);

        //void DeleteUser(int id);
    }
}
