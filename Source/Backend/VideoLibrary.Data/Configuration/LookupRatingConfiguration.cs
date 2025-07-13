using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary.Data.DbModels;

namespace VideoLibrary.Data.Configuration
{
    internal class LookupRatingConfiguration : IEntityTypeConfiguration<LookupRating>
    {
        public void Configure(EntityTypeBuilder<LookupRating> builder)
        {
            builder.ToTable("LookupRatings");

            LookupBaseConfiguration.Configure(builder);

            builder.Property(e => e.Description).IsRequired().HasMaxLength(200);
            builder.Property(e => e.TmDbId).HasMaxLength(5);

            builder.HasData(
                new LookupRating { Id = 1, Order = 1, Name = "G", TheTvDbId = 288, TmDbId = "G", Description = "Suitable for all ages" },
                new LookupRating { Id = 2, Order = 2, Name = "PG", TheTvDbId = 289, TmDbId = "PG", Description = "Parental guidance advised" },
                new LookupRating { Id = 3, Order = 3, Name = "14A", TheTvDbId = 290, TmDbId = "14A", Description = "Parental guidance advised for viewers 14 or younger" },
                new LookupRating { Id = 4, Order = 4, Name = "18A", TheTvDbId = 291, TmDbId = "18A", Description = "Parental guidance advised for viewers 18 or younger" },
                new LookupRating { Id = 5, Order = 5, Name = "R", TheTvDbId = 292, TmDbId = "R", Description = "Restricted to viewers 18 years and over" },
                new LookupRating { Id = 6, Order = 6, Name = "A", TheTvDbId = 293, TmDbId = "A", Description = "Restricted to viewers 18 years and over, sexually explicit content" },
                new LookupRating { Id = 7, Order = 7, Name = "E", TheTvDbId = 294, TmDbId = "E", Description = "Exempt. Contains material not subject to classification such as documentaries, nature, travel, music, arts and culture, sports and educational and instructional information" },
                new LookupRating { Id = 8, Order = 8, Name = "NR", TheTvDbId = null, TmDbId = "NR", Description = "No rating information" }
            );
        }
    }
}
