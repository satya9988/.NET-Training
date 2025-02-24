namespace MovieDisplay.Models
{
    public interface IMovieDAO
    {

        List<Movie> GetAllMovies();

        void AddMovie(Movie movie);
    }
}
