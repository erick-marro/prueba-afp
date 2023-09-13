using Microsoft.EntityFrameworkCore;
using PruebaAFP.API.Models;

namespace PruebaAFP.API.Data
{
    public class AFPDbContext: DbContext
    {
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Department> Departments { get; set; }


        public AFPDbContext(DbContextOptions<AFPDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Declaración de las relaciones
            modelBuilder.Entity<Enterprise>()
                .HasMany(e => e.Departments)
                .WithOne(e => e.Enterprise)
                .HasForeignKey(e => e.EnterpriseId)
                .IsRequired();
        }
    }
}
