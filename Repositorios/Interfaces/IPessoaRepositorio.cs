using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task<List<PessoaModel>> GetAll();

        Task<PessoaModel> GetById(int id);

        Task<PessoaModel> InsertPessoa(PessoaModel pessoa);

        Task<PessoaModel> UpdatePessoa(PessoaModel pessoa, int id);

        Task<bool> DeletePessoa(int id);
    }
}
