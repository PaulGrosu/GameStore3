using GameStore3.Data;
using GameStore3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameStore3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {

        private readonly DataContext _context;

        public GamesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return _context.Games.ToList(); //brb merg sa iau pepsi
        }

        [HttpGet("{Id}")]
        public Game Get(int Id)
        {
            return _context.Games.Where(game => game.Id == Id).FirstOrDefault();
        }

        [HttpPost]
        public void Post([FromBody] Game game)
        {
            _context.Games.Add(game);

            _context.SaveChanges();
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Game value)
        {
            var dbGame = _context.Games.Find(id);

            dbGame.Title = value.Title;

            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Games.Where(game => game.Id == id).ExecuteDelete();        
        }
    }
}
