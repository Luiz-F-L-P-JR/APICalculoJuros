using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.Interfaces.Calculo
{
    public interface ICalculoService
    {
        Task<decimal> PegarCalculoJurosAsync(decimal valorInicial, decimal juros, int tempo);
        Task<decimal> ChamadaApiTaxaJurosAsync();
    }
}
