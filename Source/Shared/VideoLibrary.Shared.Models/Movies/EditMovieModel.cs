using System.ComponentModel.DataAnnotations;

namespace VideoLibrary.Shared.Models.Movies
{
    public class EditMovieModel
    {
        public int MovieId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = default!;
        [MaxLength(500)]
        public string? Tagline { get; set; }
        [MaxLength(3000)]
        public string? Description { get; set; }
        [Required]
        [Range(1930, int.MaxValue, ErrorMessage = "Year Must Be At Least 1930")]
        public int? Year { get; set; }
        [Required]
        [Display(Name = "Rating")]
        public int? RatingId { get; set; }
        [Required]
        [Range(45, 240)]
        public int? Runtime { get; set; }
        [MaxLength(3)]
        public string? CountryId { get; set; }
        [MaxLength(2)]
        public string? LanguageId { get; set; }
    }
}
