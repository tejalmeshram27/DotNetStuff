using Microsoft.AspNetCore.Mvc;
using MVCMockDemo.Models;
using MVCMockDemo.ViewModels;

namespace MVCMockDemo.Controllers
{
    //Custom Routing
    //[Route("emovies/[controller]/[action]")]

    public class MovieController : Controller
    {

        //DI
        private IMovieRepo _movieRepo;
        private ICategoryRepo _categoryRepo;
		//private object movieRepo;

		public MovieController( IMovieRepo movieRepo, ICategoryRepo categoryRepo)
        {
            _movieRepo = movieRepo;
            _categoryRepo = categoryRepo;
        }

        [Route("")]
        [Route("Movie")]
        [Route("Movie/Index")]
        [Route("Movie/Index/{id:int}")]
        public IActionResult Index( int category )
        {
			IEnumerable<Movie> movies;

            string currentCategory;
            
            movies = _movieRepo.AllMovies.OrderBy(m=>m.Name) ;
            currentCategory = "All Movies";

            MovieListViewModel movieListViewModel = new MovieListViewModel
                ( _movieRepo.AllMovies, "Comedy Movie" );


            return View(movieListViewModel);
        }
    }
}
