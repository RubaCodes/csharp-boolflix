using Microsoft.EntityFrameworkCore;
using csharp_boolflix.Models;

namespace csharp_boolflix
{
    public class BoolflixContext : DbContext
    {
        public DbSet<MediaContent> MediaContents { get; set; }
        public DbSet<MediaInfo> MediaInfos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilding)
        {
            optionsBuilding.UseSqlServer("Data Source=localhost;Initial Catalog=db-boolflix;Integrated Security=True");
        }
    }
}
