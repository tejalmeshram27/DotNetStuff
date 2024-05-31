namespace MVCMockDemo.Models
{
    public interface IMovieRepo
    {
        public IEnumerable<Movie> AllMovies { get;  }

        public IEnumerable<Movie> MoviesOfTheWeek { get;  }

        Movie GetMovieById(int MovieId);

    }
}
