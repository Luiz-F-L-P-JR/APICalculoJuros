using APICalculoJuros.Application.Interfaces.Calculo;
using APICalculoJuros.Domain.Interfaces.Calculo;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.Services.Calculo
{
    public class CalculoAppService : ICalculoAppService
    {
        private readonly ICalculoService _calculoService;
        public CalculoAppService(ICalculoService calculoService)
        {
            _calculoService = calculoService;
        }

        /// <summary>
        /// Injeta o valor da operação.
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns>decimal</returns>
        public async Task<decimal> GetCalculoJurosAsync(decimal valorInicial, int tempo)
        {
            var juros = await _calculoService.ChamadaApiTaxaJurosAsync().ConfigureAwait(false);

            return await _calculoService.GetCalculoJurosAsync(valorInicial, juros, tempo);            
        }
    }
}
