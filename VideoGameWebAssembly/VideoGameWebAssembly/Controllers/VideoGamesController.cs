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

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetGameByIdAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);

            if (result == null) return NotFound("Game not found");

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddGameAsync(VideoGame newGame)
        {
            _context.Add(newGame);

            await _context.SaveChangesAsync();
            return Ok(newGame);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VideoGame>> UpdateGameAsync(int id, VideoGame updatedGame)
        {
            var dbGame = await _context.VideoGames.FindAsync(id);
            if (dbGame == null) 
                return NotFound("Game not found");

            dbGame.Title = updatedGame.Title;
            dbGame.Publisher = updatedGame.Publisher;
            dbGame.ReleaseYear = updatedGame.ReleaseYear;

            await _context.SaveChangesAsync();
            return Ok(dbGame);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteGameAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);

            if (result == null) 
                return NotFound("Game not found");

            _context.Remove(result);
            await _context.SaveChangesAsync();

            return Ok();

        }
    }
}
