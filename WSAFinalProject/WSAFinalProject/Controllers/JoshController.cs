using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class JoshController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
