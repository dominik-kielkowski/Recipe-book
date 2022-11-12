using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeBookAPI.Database.Data;
using RecipeBookAPI.Database.Models;

namespace RecipeBookAPI.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly RecipeBookDbContext _db;
        public RecipeService(RecipeBookDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            var occupationList = _db.Recipes.ToList();

            return occupationList;
        }

        public void AddRecipe(Recipe CreateRecipe)
        {
            var recipe = new Recipe
            {
                Name = CreateRecipe.Name,
                Description = CreateRecipe.Description,
                imagePath = CreateRecipe.imagePath,
                Ingredients = CreateRecipe.Ingredients
            };

            _db.Add(recipe);
            _db.SaveChanges();
        }

        public void UpdateRecipe(Recipe recipe, int id)
        {
            var curretRecipe = _db.Recipes.FirstOrDefault(x => x.Id == id);

            curretRecipe.Name = recipe.Name;
            curretRecipe.Description = recipe.Description;
            curretRecipe.imagePath = recipe.imagePath;

            _db.SaveChanges();
        }

        public void DeleteRecipe(int id)
        {
            var recipe = _db.Recipes.FirstOrDefault(x => x.Id == id);

            _db.Remove(recipe);
            _db.SaveChanges();
        }
    }
}
