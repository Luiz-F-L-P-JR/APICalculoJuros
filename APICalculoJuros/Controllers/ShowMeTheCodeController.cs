using APICalculoJuros.Application.Interfaces.ShowMeTheCode;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculoJuros.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IShowMeTheCodeAppService _showMeTheCodeAppService;
        public ShowMeTheCodeController(IShowMeTheCodeAppService showMeTheCodeAppService)
        {
            _showMeTheCodeAppService = showMeTheCodeAppService;
        }

        /// <summary>Mostra o link de um repositório online.</summary>
        /// <response code="200">Link retornado com sucesso</response>
        /// <response code="404">Link não encontrada</response>     
        /// <response code="500">Erro interno</response>
        /// <returns> Retorna o link de um repositório online.</returns>
        [HttpGet]
        [Route("showmethecode")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetLink()
        {
            var retorno = await _showMeTheCodeAppService.GetLinkAsync();

            return Ok(retorno);
        }
    }
}
