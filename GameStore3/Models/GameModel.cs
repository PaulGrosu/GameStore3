using System.ComponentModel.DataAnnotations;

namespace GameStore3.Models
{
    public class GameModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public AgeRating AgeRating { get; set; }
        
        public IFormFile Photo { get; set; }
        public string Developer { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        public GameModel()
        {
            
        }
        public GameModel(Game game)
        {
            Stream stream = new MemoryStream(game.Photo);
            Photo = new FormFile(stream, 0, game.Photo.Length, game.Title, $"{game.Title}{game.FileExtension}")
            {
                Headers = new HeaderDictionary(),
                ContentType = $"image/{game.FileExtension.Remove(0,1)}"
            };
            Id = game.Id;
            Title = game.Title;
            Price = game.Price;
            AgeRating = game.AgeRating;
            Developer = game.Developer;
            Description = game.Description;
            ShortDescription = game.ShortDescription;
        }

        public Game GetGame()
        {
            
            var game =  new Game
            {
                Id = Id ?? 0,
                Title = Title,
                Price = Price,
                AgeRating = AgeRating,
                Developer = Developer,
                Description = Description,
                ShortDescription = ShortDescription,
                FileExtension = Path.GetExtension(Photo.FileName)
            };

            var memoryStream = new MemoryStream();
            
            Photo.CopyTo(memoryStream);
            game.Photo = memoryStream.ToArray();
            return game;
        }
    }
}