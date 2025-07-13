using VideoLibrary.Shared.Models.Lookups;

namespace VideoLibrary.Service.Interfaces
{
    public interface ILookupService
    {
        Task<IEnumerable<LookupStringModel>> GetCountriesAsync(CancellationToken cancellationToken);
        Task<IEnumerable<LookupModel>> GetGenresAsync(CancellationToken cancellationToken);
        Task<IEnumerable<LookupStringModel>> GetLanguagesAsync(CancellationToken cancellationToken);
        Task<IEnumerable<LookupRatingModel>> GetRatingsAsync(CancellationToken cancellationToken);

    }
}
