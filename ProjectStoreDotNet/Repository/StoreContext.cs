using Microsoft.EntityFrameworkCore;
using ProjectStoreDotNet.Models;

namespace ProjectStoreDotNet.Repository
{
    public class StoreContext : DbContext, IStoreContext
    {
        public StoreContext() { }
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(
                new Department(1, "Computadores"),
                new Department(2, "Eletrônicos"),
                new Department(3, "Moda"),
                new Department(4, "Livros")
                );

            builder.Entity<Seller>().HasData(
                 new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0m, 1),
            new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0m, 1),
            new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0m, 3),
            new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0m, 4),
            new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0m, 3),
            new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0m, 2)
                );
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=store;User=SA;Password=Password12!;Encrypt=False");
        }


    }
}
