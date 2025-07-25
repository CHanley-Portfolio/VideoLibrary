using Microsoft.AspNetCore.Mvc;
using VideoLibrary.Service.Interfaces;
using VideoLibrary.Shared.Models.Movies;

namespace VideoLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController(IMovieService movieService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SaveMovieAsync(EditMovieModel request, CancellationToken cancellationToken)
        {
            return Ok(await movieService.SaveMovieAsync(request, cancellationToken));
        }
    }
}
