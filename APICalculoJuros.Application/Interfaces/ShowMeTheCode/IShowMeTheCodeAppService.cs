using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.Interfaces.ShowMeTheCode
{
    public interface IShowMeTheCodeAppService
    {
        Task<string> GetLinkAsync();
    }
}
