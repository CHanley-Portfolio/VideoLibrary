using Microsoft.EntityFrameworkCore;
using VideoLibrary.Shared.Models.Enums;

namespace VideoLibrary.Data.DbModels
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = default!;
        public string Slug { get; set; } = default!;
        public string? Description { get; set; }
        public int Year { get; set; }
        public int RatingId { get; set; }
        public int Runtime { get; set; }

        

        public virtual LookupRating? Rating { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; } = [];
        public virtual ICollection<Artwork> Artwork { get; set; } = [];
        public virtual ICollection<Credit> Credits { get; set; } = [];
    }
}
