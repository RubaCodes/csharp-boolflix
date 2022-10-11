using Microsoft.EntityFrameworkCore;
using csharp_boolflix.Models;

namespace csharp_boolflix
{
    public class BoolflixContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<TvSeries> TvSeries { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<MediaInfo> MediaInfos { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Feature> Features { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilding)
        {
            optionsBuilding.UseSqlServer("Data Source=localhost;Initial Catalog=db-boolflix;Integrated Security=True");
        }
    }
}
