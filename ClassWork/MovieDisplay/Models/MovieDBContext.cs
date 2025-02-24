using Microsoft.EntityFrameworkCore;

namespace MovieDisplay.Models
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options) { }


        public DbSet<Movie> Movies { get; set; }
    }
}
