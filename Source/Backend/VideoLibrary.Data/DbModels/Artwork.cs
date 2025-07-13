using VideoLibrary.Shared.Models.Enums;

namespace VideoLibrary.Data.DbModels
{
    public class Artwork
    {
        public int ArtworkId { get; set; }
        public int MovieId { get; set; }
        public byte[] Image { get; set; } = [];
        public byte[] Thumbnail { get; set; } = [];
        public ArtworkType Type { get; set; }

        public virtual Movie? Movie { get; set; }

    }
}
