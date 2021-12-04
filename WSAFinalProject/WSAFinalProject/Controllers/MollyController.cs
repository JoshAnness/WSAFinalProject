using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class MollyController : Controller
    {
        private MovieContext context { get; set; }

        public MollyController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = new List<Movie>();
            foreach (Movie m in context.Movies)
            {
                if (m.GenreId == 1)
                {
                    m.Genre = context.Genres.Find(m.GenreId);
                    movies.Add(m);
                }
                else if (m.GenreId == 2)
                {
                    m.Genre = context.Genres.Find(m.GenreId);
                    movies.Add(m);
                }
            }
            return View(movies);
        }
    }
}
