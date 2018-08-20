namespace CarDealer.App.Data
{
    using CarDealer.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class CarDealerDbContext : IdentityDbContext
    {
        public DbSet<Car> Cars { get; set; }

        public DbSet<Part> Parts { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<PartCar> PartCars { get; set; }


        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PartCar>()
                .HasKey(pc => new { pc.CarId, pc.PartId });

            builder
                .Entity<Part>()
                .HasOne(p => p.Suplier)
                .WithMany(s => s.Parts)
                .HasForeignKey(p => p.SupplierId);

            builder
                .Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId);

            builder
                .Entity<Car>()
                .HasMany(c => c.Sales)
                .WithOne(s => s.Car)
                .HasForeignKey(s => s.CarId);

            builder
                .Entity<Car>()
                .HasMany(c => c.Parts)
                .WithOne(p => p.Car)
                .HasForeignKey(p => p.CarId);

            builder
               .Entity<Part>()
               .HasMany(p => p.Cars)
               .WithOne(c => c.Part)
               .HasForeignKey(c => c.PartId);
        }
    }
}
