namespace VideoLibrary.Shared.Models.Movies
{
    public class EditMovieModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = default!;
        public string? Tagline { get; set; }
        public string? Description { get; set; }
        public int Year { get; set; }
        public int RatingId { get; set; }
        public int Runtime { get; set; }
        public string? CountryId { get; set; }
        public string? LanguageId { get; set; }
    }
}
