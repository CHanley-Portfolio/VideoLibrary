using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VideoLibrary.Data.DbModels;

namespace VideoLibrary.Data
{
    public class VideoLibraryContext(DbContextOptions<VideoLibraryContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Artwork> Artwork { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> People { get; set; }

        // Lookups
        public DbSet<LookupCountry> Countries { get; set; }
        public DbSet<LookupGenre> Genres { get; set; }
        public DbSet<LookupLanguage> Languages { get; set; }
        public DbSet<LookupRating> Ratings { get; set; }
    }


}
