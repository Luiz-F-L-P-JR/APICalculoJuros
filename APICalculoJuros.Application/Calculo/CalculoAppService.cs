using APICalculoJuros.Application.Calculo.ViewModel;
using APICalculoJuros.Domain.Calculo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.Calculo
{
    public class CalculoAppService : ICalculoAppService
    {
        private readonly ICalculoService _calculoService;
        public CalculoAppService(ICalculoService calculoService)
        {
            _calculoService = calculoService;
        }

        public async Task<CalculoViewModel> GetCalculoJuros(decimal valorInicial, decimal juros, int tempo)
        {
            var entidade = await _calculoService.GetCalculoJuros(valorInicial, juros, tempo);

            return new CalculoViewModel(entidade);
        }
    }
}
