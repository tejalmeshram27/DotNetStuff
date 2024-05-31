namespace MVCMockDemo.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }

        public string MovieStar { get; set; }

        public decimal Price { get; set; }
        public bool IsMovieOfTheWeek { get; set; }

        public int Rating { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
