using Microsoft.AspNetCore.Mvc;
using MovieDisplay.Models;

namespace MovieDisplay.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMovieDAO mov;

        public HomeController(IMovieDAO mov)
        {
            this.mov= mov;
        }


        [HttpGet]
        public IActionResult Index()
        {

            var vm = new MovieVM();

            vm.movies = mov.GetAllMovies();


            return View(vm);
        }


        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                mov.AddMovie(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}
