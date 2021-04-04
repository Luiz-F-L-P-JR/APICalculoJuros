using System;
using System.Collections.Generic;
using System.Text;

namespace APICalculoJuros.Application.Calculo.ViewModel
{
    public class CalculoViewModel
    {
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public int Tempo { get; set; }

        public CalculoViewModel()
        {

        }

        public CalculoViewModel(Domain.Calculo.Calculo entidade)
        {
            ValorInicial = entidade.ValorInicial;
            ValorFinal = entidade.ValorFinal;
            Tempo = entidade.Tempo;
        }
    }
}
