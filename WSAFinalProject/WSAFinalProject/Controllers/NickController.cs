using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class NickController : Controller
    {
        private MovieContext context { get; set; }

        public NickController(MovieContext ctx)
        {
            context = ctx;
        } 

        public IActionResult Index()
        {
            return View();
        }
    }
}
