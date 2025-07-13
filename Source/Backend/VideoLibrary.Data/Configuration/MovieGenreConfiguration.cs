using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoLibrary.Data.DbModels;

namespace VideoLibrary.Data.Configuration
{
    internal class MovieGenreConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.HasKey(e => e.MovieGenreId);

            builder.Property(e => e.MovieId).IsRequired();
            builder.Property(e => e.LookupGenreId).IsRequired();

            builder.HasOne(e => e.Movie)
                .WithMany(e => e.MovieGenres);

            builder.HasOne(e => e.Genre)
                .WithMany(e => e.MovieGenres);
        }
    }
}
