using System;
using System.Collections.Generic;
using System.Text;

namespace APICalculoJuros.Domain.Entidades.Calculo
{
    public class Calculo
    {
        /// <summary>
        /// Propriedade que indica o valor inicial da operação.
        /// </summary>
        public decimal ValorInicial { get; private set; }
        /// <summary>
        /// Propriedade que recebe um valor de juros vindo de oura API.
        /// </summary>
        public decimal Juros { get; private set; }
        /// <summary>
        /// Propriedade que recebe o valor do calculo.
        /// </summary>
        public decimal ValorFinal { get; private set; }
        /// <summary>
        /// Propriedade que representa meses.
        /// </summary>
        public int Tempo { get; private set; }

        public Calculo()
        {

        }

        public Calculo(decimal valorInicial, decimal juros, int tempo)
        {
            ValorInicial = valorInicial;
            Tempo = tempo;
            Juros = juros;
        }

        public void PegarCalculoJuros()
        {
            var valorFinal = 1 + Juros;

            valorFinal = Convert.ToDecimal(Math.Pow(Convert.ToDouble(valorFinal), Tempo));
                
            valorFinal = ValorInicial * valorFinal;
                
            valorFinal = Math.Truncate(100 * valorFinal)/100;

            ValorFinal = valorFinal;
        }
    }
}
