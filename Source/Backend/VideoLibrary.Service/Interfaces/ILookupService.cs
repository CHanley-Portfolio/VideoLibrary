using VideoLibrary.Shared.Models.Lookups;

namespace VideoLibrary.Service.Interfaces
{
    public interface ILookupService
    {
        Task<IEnumerable<LookupModel>> GetGenresAsync(CancellationToken cancellationToken);
        Task<IEnumerable<LookupRatingModel>> GetRatingsAsync(CancellationToken cancellationToken);
    }
}
