using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hoteles { get; set; }

        public DbSet<Pais> Paises { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pais>().HasData(
                new Pais
                {
                    Id = 1,
                    Nombre = "Jamaica",
                    NombreCorto = "JM"
                },
                new Pais
                {
                    Id = 2,
                    Nombre = "Bahamas",
                    NombreCorto = "BS"
                },
                new Pais
                {
                    Id = 3,
                    Nombre = "Chile",
                    NombreCorto = "CL"
                },
                new Pais
                {
                    Id = 4,
                    Nombre = "Venezuela",
                    NombreCorto = "VE"
                });
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Nombre = "Sandals Resort an Spa",
                    Direccion = "Negril",
                    PaisId = 1,
                    Reseña = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Nombre = "Comfort Suites",
                    Direccion = "George Town",
                    PaisId = 2,
                    Reseña = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Nombre = "AC Hotel",
                    Direccion = "Av Vitacura 130",
                    PaisId = 3,
                    Reseña = 4.2
                },
                new Hotel
                {
                    Id = 4,
                    Nombre = "Hotel Humbolt",
                    Direccion = "Cerro el Avila",
                    PaisId = 4,
                    Reseña = 4.7
                });
        }
    }
}
