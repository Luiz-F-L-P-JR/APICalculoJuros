using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.ShowMeTheCode
{
    public interface IShowMeTheCodeAppService
    {
        Task<Uri> GetLink();
    }
}
