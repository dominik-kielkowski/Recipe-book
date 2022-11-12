using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeBookAPI.Database.Models;
using RecipeBookAPI.Services;

namespace RecipeBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;

        public RecipeController(IRecipeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> getRecepis()
        {
            var recepis = _service.GetRecipes();

            return Ok(recepis);
        }

        [HttpPost]
        public ActionResult AddRecipe(Recipe createRecipe)
        {
            _service.AddRecipe(createRecipe);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateRecipe(Recipe recipe, int id)
        {
            _service.UpdateRecipe(recipe, id);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteRecipe(int id)
        {
            _service.DeleteRecipe(id);
            return Ok();
        }
    }
}
