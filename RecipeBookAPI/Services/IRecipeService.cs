using RecipeBookAPI.Database.Models;

namespace RecipeBookAPI.Services
{
    public interface IRecipeService
    {
        IEnumerable<Recipe> GetRecipes();
        void AddRecipe(Recipe createRecipe);
        void UpdateRecipe(Recipe recipe, int id);
        void DeleteRecipe(int id);
    }
}
