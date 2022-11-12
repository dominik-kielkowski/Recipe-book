using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
