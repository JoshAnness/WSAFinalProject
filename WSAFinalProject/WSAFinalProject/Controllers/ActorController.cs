using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class ActorController : Controller
    {
        private MovieContext context { get; set; }

        public ActorController(MovieContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
            return View("Edit", new Actor());
        }

        [HttpGet]
        public IActionResult Individual(int id) 
        {
            var actor = context.Actors.Find(id);
            return View(actor);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
            var actor = context.Actors.Find(id);
            return View("Edit", actor);
        }

        [HttpPost]
        public IActionResult Edit(Actor actor)
        {
            if (ModelState.IsValid)
            {
                if (actor.ActorId == 0)
                    context.Actors.Add(actor);
                else
                    context.Actors.Update(actor);
                context.SaveChanges();
                return RedirectToAction("Index", "Actor");
            }
            else 
            {
                ViewBag.Action = (actor.ActorId == 0) ? "Add" : "Edit";
                ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
                return View(actor);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var actor = context.Actors.Find(id);
            return View(actor);
        }

        [HttpPost]
        public IActionResult Delete(Actor actor)
        {
            context.Actors.Remove(actor);
            context.SaveChanges();
            return RedirectToAction("Index", "Actor");
        }

        public IActionResult Index()
        {
            var actors = context.Actors.OrderBy(a => a.Name).ToList();
            return View(actors);
        }
    }
}
