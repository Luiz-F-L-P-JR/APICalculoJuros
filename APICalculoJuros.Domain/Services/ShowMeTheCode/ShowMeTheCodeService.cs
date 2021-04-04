using APICalculoJuros.Domain.Interfaces.ShowMeTheCode;
using APICalculoJuros.Domain.Service.ShowMeTheCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.Service.ShowMeTheCode
{
    public class ShowMeTheCodeService : IShowMeTheCodeService
    {
        public ShowMeTheCodeService()
        {

        }

        public async Task<string> GetLinkAsync()
        {
            string link = "https://github.com/Luiz-F-L-P-JR";

            return link;
        }
    }
}
