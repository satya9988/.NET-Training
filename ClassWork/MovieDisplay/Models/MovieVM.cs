using System.ComponentModel.DataAnnotations;

namespace MovieDisplay.Models
{
    public class MovieVM
    {        
        public Movie movie { get; set; }
        public List<Movie>  movies { get; set; }

    }
}
