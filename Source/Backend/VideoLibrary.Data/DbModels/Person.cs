namespace VideoLibrary.Data.DbModels
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; } = default!;
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Profile { get; set; }
        public byte[]? Photo { get; set; } = [];

        public virtual ICollection<Credit> Credits { get; set; } = [];
    }
}
