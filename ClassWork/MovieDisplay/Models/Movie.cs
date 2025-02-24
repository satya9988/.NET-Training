using System.ComponentModel.DataAnnotations;

namespace MovieDisplay.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }

        public string year { get; set; }

        public string Producer { get; set; }


    }
}
