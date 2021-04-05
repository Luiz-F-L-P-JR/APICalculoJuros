using System;
using Xunit;

namespace APICalculoJuros.Test.Entities.Calculo
{
    public class CalculoTest
    {
        [Theory]
        [InlineData(100, 0.01, 5, 105.1)]
        [InlineData(200, 0.01, 10, 220.92)]
        [InlineData(300, 0.01, 20, 366.05)]
        public void TesteGetCalculoJuros(decimal valorInicial, decimal Juros, int Tempo, decimal resultado)
        {
            Domain.Entidades.Calculo.Calculo calculo = new Domain.Entidades.Calculo.Calculo(valorInicial, Juros, Tempo);

            calculo.GetCalculoJuros();

            decimal retorno = calculo.ValorFinal;

            Assert.Equal(retorno, resultado);
        }
    }
}
