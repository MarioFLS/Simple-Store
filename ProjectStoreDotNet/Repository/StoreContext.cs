using Microsoft.EntityFrameworkCore;
using ProjectStoreDotNet.Models;

namespace ProjectStoreDotNet.Repository
{
    public class StoreContext : DbContext, IStoreContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=store;User=SA;Password=Password12!;Encrypt=False");
        }
    }
}
