namespace MVCMockDemo.Models
{

	public class MockMovieRepo : IMovieRepo
    {
        private readonly ICategoryRepo categoryRepo = new MockCategoryRepo();

        List<Movie> _movieList;

        public MockMovieRepo()
        {
            _movieList = new List<Movie>()
            {
                new Movie()
                {
                    MovieID = 1,
                    Name = "3Idiots",
                    MovieStar = "Aamir",
                    IsMovieOfTheWeek = true,
                    Rating = 3,
                    CategoryId = 1,
                    Category = categoryRepo.GetAllCategories.ToList()[0],
                    Price = 100,


                },
                new Movie()
                {
                    MovieID = 2,
                    Name = "Munna Bhai MBBS",
                    MovieStar = "Sanju",
                    IsMovieOfTheWeek = false,
                    Rating = 4,
                    CategoryId = 2,
                    Category = categoryRepo.GetAllCategories.ToList()[1],

                    Price = 300,


                },
                new Movie()
                {
                    MovieID = 3,
                    Name = "Forrest Gump",
                    MovieStar = "Tom",
                    IsMovieOfTheWeek = true,
                    Rating = 5,
                    CategoryId = 3,
                    Category = categoryRepo.GetAllCategories.ToList()[2],

                    Price = 200,


                }
            };
        }
        public IEnumerable<Movie> AllMovies  {
            get { return _movieList; }
        }
        public IEnumerable<Movie> MoviesOfTheWeek
        {
            get { return _movieList; }
        }

		//IEnumerable<Movie> IMovieRepo.AllMovies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Movie GetMovieById(int movieId)
        {
            return AllMovies.FirstOrDefault(m => m.MovieID == movieId);
        }
    }
}
