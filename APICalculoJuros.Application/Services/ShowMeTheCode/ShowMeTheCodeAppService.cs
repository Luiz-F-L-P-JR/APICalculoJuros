using APICalculoJuros.Application.Interfaces.ShowMeTheCode;
using APICalculoJuros.Domain.Interfaces.ShowMeTheCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.Services.ShowMeTheCode
{
    public class ShowMeTheCodeAppService : IShowMeTheCodeAppService
    {
        private readonly IShowMeTheCodeService _showMeTheCodeService;
        public ShowMeTheCodeAppService(IShowMeTheCodeService showMeTheCodeService)
        {
            _showMeTheCodeService = showMeTheCodeService;
        }

        public async Task<string> GetLinkAsync()
        {
            var link = await _showMeTheCodeService.GetLinkAsync();

            return link;
        }
    }
}
