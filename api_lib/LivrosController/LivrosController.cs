using api_lib.Models;
using api_lib.Repositorios;
using api_lib.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_lib.LivrosController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepositorio _livroRepositorio;

        public LivrosController(ILivroRepositorio livroRepositorio)
        {
            _livroRepositorio = livroRepositorio;
        }
        [HttpGet("MostrarAcervo")]
        public async Task<ActionResult<List<LivroModel>>> BuscarTodosLivros()
        {
            List<LivroModel> livros = await _livroRepositorio.BuscarTodosLivros();
            return Ok(livros);
        }

        [HttpGet("BuscarPorId/{id}")]
        public async Task<ActionResult<LivroModel>> BuscarPorId(int id)
        {
            LivroModel livro = await _livroRepositorio.BuscarPorId(id);
            return Ok(livro);
        }

        [HttpPost("CadastrarLivro")]
        public async Task<ActionResult<LivroModel>> CadastrarLivro([FromBody] LivroModel livroModel)
        {
            LivroModel livro =  await _livroRepositorio.AdicionarLivro(livroModel);
            return Ok(livro);
        }

    }
}
