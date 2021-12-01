using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WSAFinalProject.Models;

namespace MovieList.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext context { get; set; }

        public MovieController(MovieContext ctx)
        {
            context = ctx;
        }

    }
}