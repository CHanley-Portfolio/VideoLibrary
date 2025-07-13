namespace VideoLibrary.Data.DbModels
{
    public class MovieGenre
    {
        public int MovieGenreId { get; set; }
        public int MovieId { get; set; }
        public int LookupGenreId { get; set; }

        public virtual Movie? Movie { get; set; }
        public virtual LookupGenre? Genre { get; set; }
    }
}
