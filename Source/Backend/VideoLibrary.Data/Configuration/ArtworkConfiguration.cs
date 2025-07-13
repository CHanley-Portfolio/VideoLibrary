using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoLibrary.Data.DbModels;
using VideoLibrary.Shared.Models.Enums;

namespace VideoLibrary.Data.Configuration
{
    internal class ArtworkConfiguration: IEntityTypeConfiguration<Artwork>
    {
        public void Configure(EntityTypeBuilder<Artwork> builder)
        {
            builder.HasKey(e => e.ArtworkId);

            builder.Property(e => e.MovieId).IsRequired();
            builder.Property(e => e.Type).HasConversion(new EnumToStringConverter<ArtworkType>()).HasMaxLength(20);

            builder.HasOne(e => e.Movie)
                .WithMany(e => e.Artwork);
        }
    }
}
