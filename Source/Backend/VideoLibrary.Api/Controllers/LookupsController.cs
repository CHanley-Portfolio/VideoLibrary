using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoLibrary.Service.Interfaces;
using VideoLibrary.Shared.Models.Lookups;

namespace VideoLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupsController(ILookupService lookupService) : ControllerBase
    {
        [HttpGet]
        [Route("~/api/Genres")]
        public async Task<IActionResult> GetGenresAsync(CancellationToken cancellationToken)
        {
            return Ok(await lookupService.GetGenresAsync(cancellationToken));
        }

        [HttpGet]
        [Route("~/api/Ratings")]
        public async Task<IActionResult> GetRatingsAsync(CancellationToken cancellationToken)
        {
            return Ok(await lookupService.GetRatingsAsync(cancellationToken));
            
        }
    }
}
