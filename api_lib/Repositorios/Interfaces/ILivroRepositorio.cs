using api_lib.Models;

namespace api_lib.Repositorios.Interfaces
{
    public interface ILivroRepositorio
    {
        Task<List<LivroModel>> BuscarTodosLivros();

        Task<LivroModel> BuscarPorId(int id);

        Task<LivroModel> AdicionarLivro(LivroModel livro);

        Task<LivroModel> AtualizarLivro(LivroModel livro, int id);

        Task<bool> ApagarLivro(int id);
    }
}
