namespace VideoLibrary.Data.DbModels
{
    public class LookupBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;       
        public int? Order { get; set; }
        public bool Deleted { get; set; }
    }
}
