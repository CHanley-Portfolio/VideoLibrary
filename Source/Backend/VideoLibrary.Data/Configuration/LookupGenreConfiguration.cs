using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoLibrary.Data.DbModels;

namespace VideoLibrary.Data.Configuration
{
    internal class LookupGenreConfiguration : IEntityTypeConfiguration<LookupGenre>
    {
        public void Configure(EntityTypeBuilder<LookupGenre> builder)
        {
            builder.ToTable("LookupGenres");

            LookupBaseConfiguration.Configure(builder);

            builder.HasData(
               new LookupGenre { Id = 1, Name = "Action", TheTvDbId = 19, TmDbId = 28 },
               new LookupGenre { Id = 2, Name = "Adventure", TheTvDbId = 18, TmDbId = 12 },
               new LookupGenre { Id = 3, Name = "Animation", TheTvDbId = 17, TmDbId = 16 },
               new LookupGenre { Id = 4, Name = "Science Fiction", TheTvDbId = 2, TmDbId = 878 },
               new LookupGenre { Id = 5, Name = "Horror", TheTvDbId = 6, TmDbId = 27 },
               new LookupGenre { Id = 6, Name = "Thriller", TheTvDbId = 24, TmDbId = 53 },
               new LookupGenre { Id = 7, Name = "Crime", TheTvDbId = 14, TmDbId = 80 },
               new LookupGenre { Id = 8, Name = "Fantasy", TheTvDbId = 10, TmDbId = 14 },
               new LookupGenre { Id = 9, Name = "Family", TheTvDbId = 11, TmDbId = 10751 },
               new LookupGenre { Id = 10, Name = "Comedy", TheTvDbId = 15, TmDbId = 35 },
               new LookupGenre { Id = 11, Name = "Documentary", TheTvDbId = 13, TmDbId = 99 },
               new LookupGenre { Id = 12, Name = "Sport", TheTvDbId = 21, TmDbId = null },
               new LookupGenre { Id = 13, Name = "Western", TheTvDbId = 26, TmDbId = 37 },
               new LookupGenre { Id = 14, Name = "Romance", TheTvDbId = 28, TmDbId = 10749 },
               new LookupGenre { Id = 15, Name = "Mystery", TheTvDbId = 31, TmDbId = 9648 },
               new LookupGenre { Id = 16, Name = "Musical", TheTvDbId = 29, TmDbId = 10402 },
               new LookupGenre { Id = 17, Name = "History", TheTvDbId = 33, TmDbId = 36 },
               new LookupGenre { Id = 18, Name = "War", TheTvDbId = 34, TmDbId = 10752 },
               new LookupGenre { Id = 19, Name = "Anime", TheTvDbId = 27, TmDbId = 16},
               new LookupGenre { Id = 20, Name = "Martial Arts", TheTvDbId = 35, TmDbId = null });
            
        }
    }
}
