using APICalculoJuros.Application.Calculo;
using APICalculoJuros.Application.Calculo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace APICalculoJuros.Controllers
{
    [ApiController]
    [Route("api/v1/calculo-juros")]
    public class CalculoJurosController : ControllerBase
    {
        private readonly ICalculoAppService _calculoAppService;
        public CalculoJurosController(ICalculoAppService calculoAppService)
        {
            _calculoAppService = calculoAppService;
        }

        /// <summary>Informa o resultado da operação.</summary>
        /// <param name="valorInicial"></param>
        /// <param name="juros"></param>
        /// <param name="tempo"></param>
        /// <response code="200">Resultado da operação</response>
        /// <response code="404">Resultado da operação não encontrado</response>     
        /// <response code="500">Erro interno</response>
        /// <returns> Retorna o valor de uma operação matemática.</returns>
        [HttpGet]
        [Route("calculaJuros")]
        public async Task<CalculoViewModel> GetCalculoJuros(decimal valorInicial, int tempo)
        {
            var uri = "https://localhost:44350";
            var pathRelativo = "swagger";

            HttpClient httpClient = new HttpClient();            
            httpClient.BaseAddress = new Uri(uri);

            HttpResponseMessage getHttpAsync = await httpClient.GetAsync(pathRelativo);

            getHttpAsync.EnsureSuccessStatusCode();

            var resposta = getHttpAsync.Content.ReadAsStringAsync();

            decimal taxaJuros = Convert.ToDecimal(resposta);

            var retorno = await _calculoAppService.GetCalculoJuros(valorInicial, taxaJuros, tempo);

            if (retorno == null) NotFound();

            return retorno;
        }

    }
}
