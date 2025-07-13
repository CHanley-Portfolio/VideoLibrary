using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VideoLibrary.Data;
using VideoLibrary.Service.Interfaces;
using VideoLibrary.Shared.Models.Lookups;

namespace VideoLibrary.Service.Services
{
    public class LookupService(ILogger<LookupService> logger, VideoLibraryContext context) : BaseService(logger, context), ILookupService
    {
        public async Task<IEnumerable<LookupStringModel>> GetCountriesAsync(CancellationToken cancellationToken)
        {
            return await ProcessMethodAsync(async () =>
            {
                return await Context.Countries
                    .OrderBy(l => l.Order).ThenBy(l => l.Name)
                    .Select(l => new LookupStringModel { Id = l.CountryId, Name = l.Name })
                    .ToListAsync(cancellationToken);
            });
        }

        public async Task<IEnumerable<LookupModel>> GetGenresAsync(CancellationToken cancellationToken)
        {
            return await ProcessMethodAsync(async () =>
            {
                return await Context.Genres
                    .Where(g => !g.Deleted)
                    .OrderBy(g => g.Name)
                    .Select(g => new LookupModel { Id = g.Id, Name = g.Name })
                    .ToListAsync(cancellationToken);
            });
        }

        public async Task<IEnumerable<LookupStringModel>> GetLanguagesAsync(CancellationToken cancellationToken)
        {
            return await ProcessMethodAsync(async () =>
            {
                return await Context.Languages
                    .OrderBy(l => l.Order).ThenBy(l => l.Name)
                    .Select(l => new LookupStringModel { Id = l.LanguageId, Name = l.Name })
                    .ToListAsync(cancellationToken);
            });
        }

        public async Task<IEnumerable<LookupRatingModel>> GetRatingsAsync(CancellationToken cancellationToken)
        {
            return await ProcessMethodAsync(async () =>
            {
                return await Context.Ratings
                    .Where(g => !g.Deleted)
                    .OrderBy(g => g.Order)
                    .Select(g => new LookupRatingModel { Id = g.Id, Name = g.Name, Description = g.Description })
                    .ToListAsync(cancellationToken);
            });
        }
    }
}
