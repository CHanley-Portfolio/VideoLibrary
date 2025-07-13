namespace VideoLibrary.Data.DbModels
{
    public class LookupCountry
    {
        public string CountryId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int Order { get; set; }

        public virtual ICollection<Movie> Movies { get; set; } = [];

    }
}
