using Autos.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Autos.Repository
{
    /// <summary>
    /// Bd context is the object to represents the database integration.
    /// </summary>
    public class AutosMarcasDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutosMarcasDbContext"/> class.
        /// <see cref="AutosMarcasDbContext"/> Constructor.
        /// </summary>
        /// <param name="options">Dependency injection options to set up the possibles configurations.</param>
        public AutosMarcasDbContext(DbContextOptions<AutosMarcasDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<MarcasAuto> MarcasAutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<MarcasAuto>().HasData(
                new MarcasAuto
                {
                    Id = new Guid("395f18a0-fa4f-4731-8eb6-75954189499a"),
                    Marca = "Toyota",
                    Modelo = "Corolla",
                    Anno = 2021,
                    Color = "Rojo",
                    IsActive = true,
                    Serial = "1234567890"
                },
                new MarcasAuto
                {
                    Id = new Guid("5a1e6b51-09cc-4d59-8f57-7a5fee10de08"),
                    Marca = "Toyota",
                    Modelo = "Camry",
                    Anno = 2024,
                    Color = "Azul",
                    IsActive = true,
                    Serial = "1234567891"
                },
                new MarcasAuto
                {
                    Id = new Guid("ccaa5951-e864-40e1-b801-a41e1470dff5"),
                    Marca = "Toyota",
                    Modelo = "Rav4",
                    Anno = 2024,
                    Color = "Blanco",
                    IsActive = true,
                    Serial = "1234567892"
                },
                new MarcasAuto
                {
                    Id = new Guid("d8b86b65-7e9c-4046-a21e-b57eb47e2fba"),
                    Marca = "Ford",
                    Modelo = "Raptor",
                    Anno = 2025,
                    Color = "Blanco",
                    IsActive = true,
                    Serial = "1234567892"
                });
        }
    }
}