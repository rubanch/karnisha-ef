using ER_Diagram.Models;
using Microsoft.EntityFrameworkCore;

namespace ER_Diagram.Connection
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<AdminAddProductClass> adminaddproductclass { get; set; }
        public DbSet<EMIcardForm> emicardform { get; set;} 
        public DbSet<ProductPurchased>productPurchaseds { get; set; }
        public DbSet<UserInfoClass> userinfoclass { get; set; }

        public DbSet <AdminClass>adminClasses { get; set; } 
        public DbSet<Userclass> userclasses { get; set; } 
    }
}
