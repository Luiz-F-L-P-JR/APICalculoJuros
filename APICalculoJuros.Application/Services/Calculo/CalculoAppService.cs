using APICalculoJuros.Application.Calculo.ViewModel;
using APICalculoJuros.Application.Interfaces.Calculo;
using APICalculoJuros.Domain.Interfaces.Calculo;
using System;
using System.Collections.Generic;
using System.Text;
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

        public async Task<decimal> GetCalculoJuros(decimal valorInicial, int tempo)
        {
            return await _calculoService.GetCalculoJuros(valorInicial, tempo);            
        }
    }
}
