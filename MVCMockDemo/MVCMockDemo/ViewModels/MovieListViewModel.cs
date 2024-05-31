using MVCMockDemo.Models;

namespace MVCMockDemo.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movie { get; set; }
        public string CurrentCategory { get; set; }
        public MovieListViewModel(IEnumerable<Movie> movies, string ? currentCategory ) 
        {
            Movie = movies;
            CurrentCategory = currentCategory;
        }


    }
}
