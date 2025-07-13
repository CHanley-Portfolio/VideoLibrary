using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoLibrary.Data.DbModels;

namespace VideoLibrary.Data.Configuration
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(e => e.MovieId);

            builder.Property(e => e.Title).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Slug).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Description).HasMaxLength(3000);
            builder.Property(e => e.Year).IsRequired();

            builder.HasOne(e => e.Rating)
                .WithMany(e => e.Movies);
        }
    }
}
