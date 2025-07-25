using Microsoft.Extensions.Logging;
using VideoLibrary.Data;
using VideoLibrary.Service.Interfaces;
using VideoLibrary.Shared.Models.Movies;

namespace VideoLibrary.Service.Services
{
    public class MovieService(ILogger<MovieService> logger, VideoLibraryContext context) : BaseService(logger, context), IMovieService
    {
        public async Task<EditMovieModel> SaveMovieAsync(EditMovieModel request, CancellationToken cancellationToken)
        {
            return await ProcessMethodAsync(async () =>
            {
                var movie = await Context.Movies.FindAsync([request.MovieId], cancellationToken) ?? new();

                movie.Title = request.Title;
                movie.Slug = request.Title.Replace(" ", "-").ToLower();
                movie.Tagline = request.Tagline;
                movie.Description = request.Description;
                movie.Year = request.Year;
                movie.RatingId = request.RatingId;
                movie.Runtime = request.Runtime;
                movie.CountryId = request.CountryId;
                movie.LanguageId = request.LanguageId;

                if (request.MovieId == 0)
                {
                    await Context.Movies.AddAsync(movie, cancellationToken);
                }
                await Context.SaveChangesAsync(cancellationToken);

                request.MovieId = movie.MovieId;
                return request;
            });
        }
    }
}
