using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.Calculo
{
    public interface ICalculoService
    {
        Task<Calculo> GetCalculoJuros(decimal valorInicial, decimal juros, int tempo);
    }
}
