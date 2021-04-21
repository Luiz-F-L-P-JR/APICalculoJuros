using APICalculoJuros.Application.Interfaces.Calculo;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APICalculoJuros.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class CalculoJurosController : ControllerBase
    {
        private readonly ICalculoAppService _calculoAppService;
        public CalculoJurosController(ICalculoAppService calculoAppService)
        {
            _calculoAppService = calculoAppService;
        }

        /// <summary>Informa o resultado da operação.</summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <response code="200">Operação retornada com sucesso</response>
        /// <response code="404">Resultado da operação não encontrado</response>     
        /// <response code="500">Erro interno</response>
        /// <returns> Retorna o valor de uma operação matemática.</returns>
        [HttpGet]
        [Route("calculaJuros")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAsync(decimal valorInicial, int tempo)
        {
            var retorno = await _calculoAppService.PegarCalculoJurosAsync(valorInicial, tempo).ConfigureAwait(false);

            return Ok(retorno);
        }

    }
}
