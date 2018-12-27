using Microsoft.EntityFrameworkCore;

namespace AgriAnalyticoServer.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Crop> Crops { get; set; }
        public DbSet<Soil> Soils { get; set; }
    }
}