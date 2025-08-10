using Microsoft.EntityFrameworkCore;
using LogyxAccounting.Models;
using LogyxAccounting.Models.Repository;

namespace LogyxAccounting.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        public DbSet<ProductsRepository> Products { get; set; }

        public DbSet<AccountsRepository> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductsRepository>()
                        .ToTable("products", "meyvavile");

            modelBuilder.Entity<AccountsRepository>()
                        .ToTable("accounts", "meyvavile");
        }
    }


}




