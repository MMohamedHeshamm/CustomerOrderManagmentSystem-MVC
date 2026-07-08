

using CustomerOrderManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerOrderManagmentSystem.Data
{
    public class App_dbContext : DbContext
    {

        public App_dbContext(DbContextOptions<App_dbContext> options) : base(options)
        {
            
        }


        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }



    }
}
