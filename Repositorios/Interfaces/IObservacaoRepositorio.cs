using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IObservacaoRepositorio
    {
        Task<List<ObservacoesModel>> GetAll();

        Task<ObservacoesModel> GetById(int id);

        Task<ObservacoesModel> InsertObservacaoes(ObservacoesModel observacaoes);

        Task<List<ObservacoesModel>> GetObservacaoPessoaId(int id);

        Task<ObservacoesModel> UpdateObservacaoes(ObservacoesModel observacaoes, int id);

        Task<bool> DeleteObservacaoes(int id); 
    }
}
