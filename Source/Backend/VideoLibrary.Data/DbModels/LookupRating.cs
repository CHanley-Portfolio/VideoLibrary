namespace VideoLibrary.Data.DbModels
{
    public class LookupRating: LookupBase
    {
        public string Description { get; set; } = default!;

        public string? TmDbId { get; set; }

        public int? TheTvDbId { get; set; }

        public virtual ICollection<Movie> Movies { get; set; } = [];
    }
}
