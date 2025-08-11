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

        public DbSet<MeasureUnitsRepository> MeasureUnits { get; set; }

        public DbSet<ProductCategoriesRepository> ProductCategories { get; set; }

        public DbSet<ProductTypesRepository> ProductTypes { get; set; }

        public DbSet<TaxationTypesRepository> TaxationTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductsRepository>()
                        .ToTable("products", "meyvavile");

            modelBuilder.Entity<AccountsRepository>()
                        .ToTable("accounts", "meyvavile");

            modelBuilder.Entity<MeasureUnitsRepository>()
            .ToTable("measure_units", "meyvavile");

            modelBuilder.Entity<ProductCategoriesRepository>()
            .ToTable("product_categories", "meyvavile");

            modelBuilder.Entity<ProductTypesRepository>()
                .ToTable("product_types", "main");

            modelBuilder.Entity<TaxationTypesRepository>()
                 .ToTable("taxation_types", "main");


        }
    }


}




