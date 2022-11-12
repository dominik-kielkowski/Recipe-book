using RecipeBookAPI.Database.Models;

namespace RecipeBookAPI.Services
{
    public interface IIngredientService
    {
        IEnumerable<Ingredient> GetIngredients();
        void AddIngredient(Ingredient createIngredient);
        void UpdateIngredient(Ingredient newIngredient, int id);
        void DeleteIngredient(int id);
    }
}