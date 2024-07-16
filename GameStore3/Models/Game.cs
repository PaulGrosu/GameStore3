using System.ComponentModel.DataAnnotations;

namespace GameStore3.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public AgeRating AgeRating { get; set; }
        //public byte[] Photo { get; set; }
        public string Developer { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
    }
}
