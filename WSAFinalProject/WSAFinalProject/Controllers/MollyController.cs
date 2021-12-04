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
            return View();
        }
    }
}
