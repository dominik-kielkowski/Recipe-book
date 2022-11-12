using RecipeBookAPI.Database.Data;
using RecipeBookAPI.Database.Models;

namespace RecipeBookAPI.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly RecipeBookDbContext _db;

        public IngredientService(RecipeBookDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Ingredient> GetIngredients()
        {
            var ingredientList = _db.Ingredients.ToList();

            return ingredientList;
        }

        public void AddIngredient(Ingredient createIngredient)
        {
            var ingredient = new Ingredient
            {
                Name = createIngredient.Name,
                Amount = createIngredient.Amount,
                RecipeId = createIngredient.RecipeId
                
            };
            
            _db.Ingredients.Add(ingredient);
            _db.SaveChanges();
        }

        public void UpdateIngredient(Ingredient newIngredient, int id)
        {
            var currentIngredient = _db.Ingredients.FirstOrDefault(x => x.Id == id);

            currentIngredient.Name = newIngredient.Name;
            currentIngredient.Amount = newIngredient.Amount;

            _db.SaveChanges();
        }

        public void DeleteIngredient(int id)
        {
            var ingredient = _db.Ingredients.FirstOrDefault(x => x.Id == id);

            _db.Ingredients.Remove(ingredient);
            _db.SaveChanges();
        }
    }
}
