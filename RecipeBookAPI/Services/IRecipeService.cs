using RecipeBookAPI.Database.Models;

namespace RecipeBookAPI.Services
{
    public interface IRecipeService
    {
        Recipe GetRecipe(int id);
        IEnumerable<Recipe> GetRecipes();
        void AddRecipe(Recipe createRecipe);
        void UpdateRecipe(Recipe recipe, int id);
        void DeleteRecipe(int id);
    }
}
