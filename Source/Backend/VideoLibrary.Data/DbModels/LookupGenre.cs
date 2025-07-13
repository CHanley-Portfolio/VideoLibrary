namespace VideoLibrary.Data.DbModels
{
    public class LookupGenre : LookupBase

    {

        public int? TmDbId { get; set; }

        public int? TheTvDbId { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; } = [];

    }

}
