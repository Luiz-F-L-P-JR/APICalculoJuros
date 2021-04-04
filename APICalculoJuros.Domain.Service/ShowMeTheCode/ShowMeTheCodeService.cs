using APICalculoJuros.Domain.ShowMeTheCode;
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

        public async Task<Uri> GetLink()
        {
            Uri link = new Uri("https://github.com/Luiz-F-L-P-JR");

            return await Task.FromResult(link);
        }
    }
}
