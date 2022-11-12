namespace RecipeBookAPI.Services
{
    public interface IIngredientService
    {
        IEnumerable<IngredientService> GetIngredients();
    }
}