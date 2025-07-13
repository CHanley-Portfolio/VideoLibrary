namespace VideoLibrary.Data.DbModels
{
    public class LookupLanguage
    {
        public string LanguageId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int Order { get; set; }

        public virtual ICollection<Movie> Movies { get; set; } = [];
    }
}
