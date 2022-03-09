using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using HyperMarket.DB.Models;

namespace HyperMarket.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        #region Public properties
        public DbSet<User> Users { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<BusinessDetail> BusinessDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<ErrorType> ErrorTypes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Config> Config { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        //    #region Overidden methods
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<User>().HasData(GetUsers());
        //        base.OnModelCreating(modelBuilder);
        //    }
        //    #endregion


        //    #region Private methods
        //    private List<User> GetUsers()
        //    {
        //        return new List<User>
        //{
        //    new User { UserId = 1, FirstName = "Sowmya", LastName = "Ganne", MobileNumber = 9491217132 , EmailAddress ="sowmyaganne25@gmail.com", Address="1-2/314, PQ Nagar "}
        //    //new User { Id = 1002, Name = "Microsoft Office", Price = 20.99, Quantity = 50, Description ="This is a Office Application"},
        //    //new User { Id = 1003, Name = "Lazer Mouse", Price = 12.02, Quantity = 20, Description ="The mouse that works on all surface"},
        //    //new User { Id = 1004, Name = "USB Storage", Price = 5.00, Quantity = 20, Description ="To store 256GB of data"}
        //};
        //    }
        //    #endregion
    }
}