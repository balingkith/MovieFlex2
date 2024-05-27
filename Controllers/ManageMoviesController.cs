using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieFlex.Data.Entities;
using MovieFlex.Data.Enums;

namespace MovieFlex.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManageMoviesController : Controller
    {
        public IActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Action . Adventure",
                    Title = "Damsel",
                    Description = "",
                    ImageUrl = "~/img/img1.jpg",
                    Category = MovieCategory.Top10,
                },
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Action . Fantasy",
                    Title = "Godzilla Vs Kung The New Empire",
                    Description = "",
                    ImageUrl = "~/img/img2.jpg",
                    Category = MovieCategory.Top10,
                },
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Action . Suspense",
                    Title = "The Beekeeper",
                    Description = "",
                    ImageUrl = "~/img/img3.jpg",
                    Category = MovieCategory.Top10,
                },
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Animation",
                    Title = "Kung Fu Panda 4",
                    Description = "",
                    ImageUrl = "~/img/img4.jpg",
                    Category = MovieCategory.Top10,
                },
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Action . Adventure",
                    Title = "Top Gun: Maverick",
                    Description = "",
                    ImageUrl = "~/img/img5.jpg",
                    Category = MovieCategory.BlockBuster,
                },
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Action . Thriller",
                    Title = "Olympus Has Fallen",
                    Description = "",
                    ImageUrl = "~/img/img6.jpg",
                    Category = MovieCategory.BlockBuster,
                },
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Action . Thriller",
                    Title = "John Wick",
                    Description = "",
                    ImageUrl = "~/img/img7.jpg",
                    Category = MovieCategory.BlockBuster,
                },
                new Movie{
                    Id = Guid.NewGuid().ToString(),
                    Year = "2024",
                    Genre = "Action . Sci-Fi",
                    Title = "Transformers",
                    Description = "",
                    ImageUrl = "~/img/img8.jpg",
                    Category = MovieCategory.BlockBuster,
                },
            };
            return View(movies);
        }
    }
}
