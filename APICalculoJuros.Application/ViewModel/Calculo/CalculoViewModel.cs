using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APICalculoJuros.Application.Calculo.ViewModel
{
    public class CalculoViewModel
    {
        [Required(ErrorMessage="campo Valor Inicial Obrigatorio")]        
        public decimal ValorInicial { get; set; }

        [Required(ErrorMessage = " campo tempo Obrigatorio")]        
        public int Tempo { get; set; }      
    }
}
