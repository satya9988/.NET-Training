
namespace MovieDisplay.Models
{
    public class MovieDAO : IMovieDAO
    {

        private readonly MovieDBContext ctx;

        public MovieDAO(MovieDBContext ctx)
        {
            this.ctx = ctx;
        }

        public void AddMovie(Movie movie)
        {
            ctx.Movies.Add(movie);
            ctx.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
           return ctx.Movies.ToList();
        }
    }
}
