using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoLibrary.Data.DbModels;
using VideoLibrary.Shared.Models.Enums;

namespace VideoLibrary.Data.Configuration
{
    public class CreditConfiguration : IEntityTypeConfiguration<Credit>
    {
        public void Configure(EntityTypeBuilder<Credit> builder)
        {
            builder.HasKey(e => e.CreditId);

            builder.Property(e => e.MovieId).IsRequired();
            builder.Property(e => e.PersonId).IsRequired();
            builder.Property(e => e.Type).HasConversion(new EnumToStringConverter<CreditType>()).HasMaxLength(20);

            builder.HasOne(e => e.Movie).WithMany(e => e.Credits);
            builder.HasOne(e => e.Person).WithMany(e => e.Credits);
        }
    }
}
