
using System.ComponentModel.DataAnnotations;

namespace RecipeBookAPI.Database.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string imagePath { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
