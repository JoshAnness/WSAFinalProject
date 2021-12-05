using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context {get; set;}

        public HomeController(MovieContext ctx) {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.OrderBy(m => m.Name).ToList();
            foreach(Movie m in movies)
            {
                m.Genre = context.Genres.Find(m.GenreId);
            }
            return View(movies);
        }


    }
}
