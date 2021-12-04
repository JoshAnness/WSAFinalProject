using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class HenryController : Controller
    {
        private MovieContext context { get; set; }

        public HenryController(MovieContext ctx)
        {
            context = ctx;
        } 

        public IActionResult Index()
        {
            return View();
        }
    }
}
