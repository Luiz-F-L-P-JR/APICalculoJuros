using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.ShowMeTheCode
{
    public interface IShowMeTheCodeService
    {
        Task<Uri> GetLink();
    }
}
