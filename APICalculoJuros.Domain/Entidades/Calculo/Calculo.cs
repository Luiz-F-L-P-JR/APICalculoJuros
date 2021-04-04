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

        public void GetCalculoJuros()
        {
            var valorFinal = 1 + Juros;

            //this.ValorFinal = (decimal)Math.Pow((double)this.ValorFinal, this.Tempo);

            //this.ValorFinal = this.ValorInicial * this.ValorFinal;

            //this.ValorFinal = Math.Round(this.ValorFinal, 2);

            //return this.ValorFinal;

            ValorFinal = Math.Truncate(100 * (ValorInicial * Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + Juros), Tempo)))) / 100;


        }
    }
}
