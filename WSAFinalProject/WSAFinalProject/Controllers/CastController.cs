using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class CastController : Controller
    {
        private MovieContext context { get; set; }

        public CastController(MovieContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
            ViewBag.Actors = context.Actors.OrderBy(a => a.Name).ToList();
            return View("Edit", new Cast());
        }

        [HttpGet]
        public IActionResult Individual(int id)
        {
            var cast = context.Casts.Find(id);
            return View(cast);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
            ViewBag.Actors = context.Actors.OrderBy(a => a.Name).ToList();
            var cast = context.Casts.Find(id);
            return View("Edit", cast);
        }

        [HttpPost]
        public IActionResult Edit(Cast cast)
        {
            if (ModelState.IsValid)
            {
                if (cast.CastId == 0)
                    context.Casts.Add(cast);
                else
                    context.Casts.Update(cast);
                context.SaveChanges();
                return RedirectToAction("Index", "Cast");
            }
            else
            {
                ViewBag.Action = (cast.CastId == 0) ? "Add" : "Edit";
                ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
                ViewBag.Actors = context.Actors.OrderBy(a => a.Name).ToList();
                return View(cast);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cast = context.Casts.Find(id);
            return View(cast);
        }

        [HttpPost]
        public IActionResult Delete(Cast cast)
        {
            context.Casts.Remove(cast);
            context.SaveChanges();
            return RedirectToAction("Index", "Cast");
        }

        public IActionResult Index()
        {
            var casts = context.Casts.OrderBy(c => c.CastId).ToList();
            return View(casts);
        }
    }
}
