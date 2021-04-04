using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.Interfaces.ShowMeTheCode
{
    public interface IShowMeTheCodeService
    {
        Task<string> GetLinkAsync();
    }
}
