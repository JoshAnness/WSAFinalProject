using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAFinalProject.Models;

namespace WSAFinalProject.Controllers
{
    public class DescriptionController : Controller
    {
        private MovieContext context { get; set; }

        public DescriptionController(MovieContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
            return View("Edit", new Description());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
            var description = context.Descriptions.Find(id);
            return View("Edit", description);
        }

        [HttpPost]
        public IActionResult Edit(Description description)
        {
            if (ModelState.IsValid)
            {
                if (description.DescriptionId == 0)
                    context.Descriptions.Add(description);
                else
                    context.Descriptions.Update(description);
                context.SaveChanges();
                return RedirectToAction("Index", "Description");
            }
            else
            {
                ViewBag.Action = (description.DescriptionId == 0) ? "Add" : "Edit";
                ViewBag.Movies = context.Movies.OrderBy(m => m.Name).ToList();
                return View(description);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var description = context.Descriptions.Find(id);
            return View(description);
        }

        [HttpPost]
        public IActionResult Delete(Description description)
        {
            context.Descriptions.Remove(description);
            context.SaveChanges();
            return RedirectToAction("Index", "Description");
        }

        public IActionResult Index()
        {
            var descriptions = context.Descriptions.OrderBy(d => d.DescriptionId).ToList();
            return View(descriptions);
        }
    }
}
