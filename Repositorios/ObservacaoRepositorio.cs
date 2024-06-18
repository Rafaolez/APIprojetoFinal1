using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class ObservacaoRepositorio : IObservacaoRepositorio
    {
        private readonly Contexto _dbContext;
        public ObservacaoRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ObservacoesModel>> GetAll()
        {
            return await _dbContext.Observacoes.ToListAsync();
        }

        public async Task<ObservacoesModel> GetById(int id)
        {
            return await _dbContext.Observacoes.FirstOrDefaultAsync(x => x.ObservacoesId == id);
        }

        public async Task<List<ObservacoesModel>> GetObservacaoPessoaId(int id)
        {
            return await _dbContext.Observacoes.Where(x => x.PessoaId == id).ToListAsync();
        } 

        public async Task<ObservacoesModel> InsertObservacaoes(ObservacoesModel observacaoes)
        {
            await _dbContext.Observacoes.AddAsync(observacaoes);
            await _dbContext.SaveChangesAsync();
            return observacaoes;
        }

        public async Task<ObservacoesModel> UpdateObservacaoes(ObservacoesModel observacaoes, int id)
        {
            ObservacoesModel observacaoe = await GetById(id);
            if (observacaoe == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                observacaoe.ObservacoesLocal = observacaoes.ObservacoesLocal;
                observacaoe.ObservacoesData = observacaoes.ObservacoesData;
                observacaoe.ObservacoesDescricao = observacaoes.ObservacoesDescricao;
                observacaoe.UsuarioId = observacaoes.UsuarioId;
                observacaoe.PessoaId = observacaoes.PessoaId;
                _dbContext.Observacoes.Update(observacaoe);
                await _dbContext.SaveChangesAsync();
            }
            return observacaoe;

        }

        public async Task<bool> DeleteObservacaoes(int id)
        {
            ObservacoesModel observacaoes = await GetById(id);
            if (observacaoes == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Observacoes.Remove(observacaoes);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
