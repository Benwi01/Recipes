using Microsoft.AspNetCore.Mvc;
using RecipeBlog.Models;
using System;
using System.Collections.Generic;

namespace RecipeBlog.Controllers
{
    public class RecipesController : Controller
    {
        private static List<Recipe> recipes = new List<Recipe>();

        public IActionResult Index()
        {
            return View(recipes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                recipe.Id = recipes.Count + 1;
                recipe.CreatedDate = DateTime.Now;
                recipes.Add(recipe);
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        public IActionResult Details(int id)
        {
            var recipe = recipes.Find(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }
    }
}