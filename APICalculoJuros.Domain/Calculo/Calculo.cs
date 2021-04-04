using System;
using System.Collections.Generic;
using System.Text;

namespace APICalculoJuros.Domain.Calculo
{
    public class Calculo
    {
        /// <summary>
        /// Propriedade de indica o valor inicial da operação.
        /// </summary>
        public decimal ValorInicial { get; set; }
        /// <summary>
        /// Propriedade que recebe o valor do calculo.
        /// </summary>
        public decimal ValorFinal { get; set; }
        /// <summary>
        /// Propriedade que representa meses.
        /// </summary>
        public int Tempo { get; set; }

        public decimal GetCalculoJuros(decimal valorInicial, decimal juros, int tempo)
        {
            this.ValorInicial = valorInicial;
            this.Tempo = tempo;

            this.ValorFinal = 1 + juros;

            this.ValorFinal = (decimal)Math.Pow((double)this.ValorFinal, this.Tempo);

            this.ValorFinal = this.ValorInicial * this.ValorFinal;

            this.ValorFinal = Math.Round(this.ValorFinal, 2);

            return this.ValorFinal;
        }
    }
}
