using APICalculoJuros.Domain.ShowMeTheCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Application.ShowMeTheCode
{
    public class ShowMeTheCodeAppService : IShowMeTheCodeAppService
    {
        private readonly IShowMeTheCodeService _showMeTheCodeService;
        public ShowMeTheCodeAppService(IShowMeTheCodeService showMeTheCodeService)
        {
            _showMeTheCodeService = showMeTheCodeService;
        }

        public async Task<Uri> GetLink()
        {
            var link = await _showMeTheCodeService.GetLink();

            return link;
        }
    }
}
