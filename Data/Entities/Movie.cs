using MovieFlex.Data.Enums;

namespace MovieFlex.Data.Entities
{
    public class Movie
    {
        public string Id { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public MovieCategory Category { get; set; }
    }
}
