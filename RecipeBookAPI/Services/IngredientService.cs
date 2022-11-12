using RecipeBookAPI.Database.Data;

namespace RecipeBookAPI.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly RecipeBookDbContext _db;

        public IngredientService(RecipeBookDbContext db)
        {
            _db = db;
        }

        public IEnumerable<IngredientService> GetIngredients()
        {
            var ingredientList = _db.Ingredients.ToList();

            return (IEnumerable<IngredientService>)ingredientList;
        }
    }
}
