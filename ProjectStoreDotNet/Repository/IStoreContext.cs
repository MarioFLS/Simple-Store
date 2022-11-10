using Microsoft.EntityFrameworkCore;
using ProjectStoreDotNet.Models;

namespace ProjectStoreDotNet.Repository
{
    public interface IStoreContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public int SaveChanges();
    }
}
