using APICalculoJuros.Application.Calculo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.Interfaces.Calculo
{
    public interface ICalculoAppService
    {
        Task<decimal> GetCalculoJuros(decimal valorInicial, int tempo);
    }
}
