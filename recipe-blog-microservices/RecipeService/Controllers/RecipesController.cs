using Microsoft.AspNetCore.Mvc;
using RecipeService.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private static List<Recipe> recipes = new List<Recipe>();

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetRecipes()
        {
            return Ok(recipes);
        }

        [HttpGet("{id}")]
        public ActionResult<Recipe> GetRecipeById(int id)
        {
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

        [HttpPost]
        public ActionResult<Recipe> CreateRecipe([FromBody] Recipe recipe)
        {
            recipe.Id = recipes.Count > 0 ? recipes.Max(r => r.Id) + 1 : 1;
            recipes.Add(recipe);
            return CreatedAtAction(nameof(GetRecipeById), new { id = recipe.Id }, recipe);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateRecipe(int id, [FromBody] Recipe updatedRecipe)
        {
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            recipe.Title = updatedRecipe.Title;
            recipe.Ingredients = updatedRecipe.Ingredients;
            recipe.Instructions = updatedRecipe.Instructions;
            recipe.CreatedAt = updatedRecipe.CreatedAt;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRecipe(int id)
        {
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            recipes.Remove(recipe);
            return NoContent();
        }
    }
}