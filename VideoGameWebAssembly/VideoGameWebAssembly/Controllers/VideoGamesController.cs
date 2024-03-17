using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameWebAssembly.Data;
using VideoGameWebAssembly.Shared.Entities;

namespace VideoGameWebAssembly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly DataContext _context;

        public VideoGamesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGamesAsync()
        {
            return await _context.VideoGames.ToListAsync();
        }
    }
}
