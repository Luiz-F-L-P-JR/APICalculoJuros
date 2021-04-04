using APICalculoJuros.Domain.Calculo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.Service.Calculo
{
    public class CalculoService : Domain.Calculo.Calculo, ICalculoService
    {
        public CalculoService()
        {

        }

        public async Task<Domain.Calculo.Calculo> GetCalculoJuros(decimal valorInicial, decimal juros, int tempo)
        {
            var entidade = new Domain.Calculo.Calculo();

            entidade.GetCalculoJuros(valorInicial, juros, tempo);

            return await Task.FromResult(entidade);
        }
    }
}
