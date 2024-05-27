using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieFlex.Models;
using System.Diagnostics;

namespace MovieFlex.Controllers
{
    
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult BrowseMovies()
        {
            return View();
        }
    }
}