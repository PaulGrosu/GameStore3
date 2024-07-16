using GameStore3.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<Game> GetTest()
        {

            
            return new Game
            {
                Title = "test",
                Price = 10.5M,
                AgeRating = AgeRating.NC17,
                Developer = "Fanteziile lui paul",
                Description = "Mi-e rusine sa descriu"
            };
        }

        [HttpGet]
        public IActionResult GetPrice(string input)
        {
            input = input.ToLower().Trim();

            if (input == "free")
                return Ok("The product is free");

            bool success = decimal.TryParse(input, out var parsedInput);

            if (!success)
                return BadRequest($"{input} nu este un nr valid");

            return Ok($"The price is {parsedInput}");

        }
    }
}
