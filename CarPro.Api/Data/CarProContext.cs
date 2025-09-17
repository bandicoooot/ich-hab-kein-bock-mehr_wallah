using Microsoft.EntityFrameworkCore;
using CarPro.Api.Models;

namespace CarPro.Api.Data
{
    public class CarProContext : DbContext
    {
        public CarProContext(DbContextOptions<CarProContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<PurchaseContract> PurchaseContracts { get; set; }
    }
}
