using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObservacaoesControler : ControllerBase
    {
        private readonly IObservacaoRepositorio _observacaoRepositorio;
        public ObservacaoesControler(IObservacaoRepositorio observacaoRepositorio)
        {
            _observacaoRepositorio = observacaoRepositorio;
        }

        [HttpGet("GetAllPessoa")]
        public async Task<ActionResult<List<ObservacoesModel>>> GetAllObservacaoes()
        {
            List<ObservacoesModel> observacaoes = await _observacaoRepositorio.GetAll();
            return Ok(observacaoes);
        }

        [HttpGet("GetProductsId/{id}")]
        public async Task<ActionResult<ObservacoesModel>> GetObservacaoesId(int id)
        {
            ObservacoesModel observacaoes = await _observacaoRepositorio.GetById(id);
            return Ok(observacaoes);
        }


        [HttpPost("CreateObservacaoes")]
        public async Task<ActionResult<ObservacoesModel>> InsertObservacaoes([FromBody] ObservacoesModel observacoesModel)
        {
            ObservacoesModel observacaoes = await _observacaoRepositorio.InsertObservacaoes(observacoesModel);
            return Ok(observacaoes);
        }

        [HttpPut("UpdateObservacaoes/{id:int}")]
        public async Task<ActionResult<ObservacoesModel>> UpdateObservacaoes(int id, [FromBody] ObservacoesModel observacoesModel)
        {
            observacoesModel.ObservacoesId = id;
            ObservacoesModel product = await _observacaoRepositorio.UpdateObservacaoes(observacoesModel, id);
            return Ok(product);
        }

        [HttpDelete("DeleteObservacoes/{id:int}")]
        public async Task<ActionResult<ObservacoesModel>> DeleteObservacaoes(int id)
        {
            bool deleted = await _observacaoRepositorio.DeleteObservacaoes(id);
            return Ok(deleted);
        }
    }
}




