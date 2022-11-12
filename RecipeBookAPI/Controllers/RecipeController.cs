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
        [Route("{id}")]
        public ActionResult<Recipe> getRecipe(int id)
        {
            var reciepe = _service.GetRecipe(id);

            return Ok(reciepe);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> getRecipes()
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
