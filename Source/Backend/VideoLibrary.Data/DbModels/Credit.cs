using VideoLibrary.Shared.Models.Enums;

namespace VideoLibrary.Data.DbModels
{
    public class Credit
    {
        public int CreditId { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public CreditType Type { get; set; }

        public virtual Movie? Movie { get; set; }
        public virtual Person? Person { get; set; }
    }
}
