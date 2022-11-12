using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeBookAPI.Database.Models;
using RecipeBookAPI.Services;

namespace RecipeBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _service;
        public IngredientController(IIngredientService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetIngredients()
        {
            var ingredients = _service.GetIngredients();
            return Ok(ingredients);
        }

        [HttpPost]
        public ActionResult AddIngredient(Ingredient createIngredient)
        {
            _service.AddIngredient(createIngredient);

            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateIngredient(Ingredient newIngredient, int id)
        {
            _service.UpdateIngredient(newIngredient, id);

            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteIngredient(int id)
        {
            _service.DeleteIngredient(id);

            return Ok();
        }
    }
}
