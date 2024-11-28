using api_lib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_lib.LivrosController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<LivroModel>> BuscarTodosLivros()
        {
            return Ok();
        }
    }
}
