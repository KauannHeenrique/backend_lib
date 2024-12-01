using api_lib.Data;
using api_lib.Models;
using api_lib.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_lib.Repositorios
{
    public class LivroRepositorio : ILivroRepositorio
    {
        private readonly SistemaBibliotecaDBContext _dBContext;

        public LivroRepositorio(SistemaBibliotecaDBContext SistemaBibliotecaDBContext)
        {
            _dBContext = SistemaBibliotecaDBContext;
        }

        public async Task<LivroModel> BuscarPorId(int id)
        {
            return await _dBContext.Livros.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<LivroModel>> BuscarTodosLivros()
        {
            return await _dBContext.Livros.ToListAsync();
        }

        public async Task<LivroModel> AdicionarLivro(LivroModel livro)
        {
            await _dBContext.Livros.AddAsync(livro);
            await _dBContext.SaveChangesAsync();

            return livro;
        }

        public async Task<LivroModel> AtualizarLivro(LivroModel livro, int id)
        {
            LivroModel livroPorId = await BuscarPorId(id);

            if (livroPorId == null)
            {
                throw new Exception($"Livro de ID {id} não foi encontrado.");
            }

            livroPorId.TituloLivro = livro.TituloLivro;
            livroPorId.AutorLivro = livro.AutorLivro;
            livroPorId.AnoLancamento = livro.AnoLancamento;
            livroPorId.QuantidadeDisponivel = livro.QuantidadeDisponivel;

            _dBContext.Livros.Update(livroPorId);
            await _dBContext.SaveChangesAsync();

            return livroPorId;
        }

        public async Task<bool> ApagarLivro(int id)
        {
            LivroModel livroPorId = await BuscarPorId(id);

            if (livroPorId == null)
            {
                throw new Exception($"Livro de ID {id} não foi encontrado.");
            }

            _dBContext.Livros.Remove(livroPorId);
            await _dBContext.SaveChangesAsync();
            return true;
        }

        public Task<List<LivroModel>> BuscarPorId()
        {
            throw new NotImplementedException();
        }
    }
}
