using APICalculoJuros.Application.Calculo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.Calculo
{
    public interface ICalculoAppService
    {
        Task<CalculoViewModel> GetCalculoJuros(decimal valorInicial, decimal juros, int tempo);
    }
}
