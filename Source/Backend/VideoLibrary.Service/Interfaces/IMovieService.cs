using VideoLibrary.Shared.Models.Movies;

namespace VideoLibrary.Service.Interfaces
{
    public interface IMovieService
    {
        Task<EditMovieModel> SaveMovieAsync(EditMovieModel request, CancellationToken cancellationToken);
    }
}
