namespace MvcTemplateDemo.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string MName { get; set; }
        public int MRating { get; set; }
        public string MStar { get; set; }
    }

    public class MovDetails
    {
        public int Id { get; set; }
        public string MName { get; set; }

        public int MRating { get; set; }

        public string MStar { get; set; }
    }
}
