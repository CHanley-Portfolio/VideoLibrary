using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoLibrary.Data.DbModels;

namespace VideoLibrary.Data.Configuration
{
    public static class LookupBaseConfiguration
    {
        public static void Configure<TLookupType>(EntityTypeBuilder<TLookupType> builder) where TLookupType : LookupBase
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Deleted).HasDefaultValue(false);
        }
    }
}
