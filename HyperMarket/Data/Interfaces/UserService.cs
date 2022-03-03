using HyperMarket.Data;
using HyperMarket.DB.Models;

namespace HyperMarket.DB.Interfaces
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
            return user;
        }

        public void SaveUser(User user)
        {
            if (user.UserId == 0) _dbContext.Users.Add(user);
            else _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var customer = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
            if (customer != null)
            {
                _dbContext.Users.Remove(customer);
                _dbContext.SaveChanges();
            }
        }
    }
}
