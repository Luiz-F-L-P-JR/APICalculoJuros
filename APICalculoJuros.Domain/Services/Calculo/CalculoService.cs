using APICalculoJuros.Domain.Interfaces.Calculo;
using APICalculoJuros.Domain.Interfaces.infra.HttpClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.Service.Calculo
{
    public class CalculoService : ICalculoService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClient _httpclient;

        public CalculoService(IConfiguration configuration, IHttpClient httpclient)
        {
            _configuration = configuration;
            _httpclient = httpclient;
        }

        public async Task<decimal> GetCalculoJurosAsync(decimal valorInicial, decimal juros, int tempo)
        {
            var entidade = new Entidades.Calculo.Calculo(valorInicial, juros, tempo);

            entidade.GetCalculoJuros();

            return entidade.ValorFinal;
        }

        public async Task<decimal> ChamadaApiTaxaJurosAsync()
        {
            var uri = _configuration.GetSection("ApiTaxaJuros").Value;
            var retornoHttpMessage = await _httpclient.GetAsync(uri).ConfigureAwait(false);
            if (retornoHttpMessage.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<decimal>(await retornoHttpMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
                return result;
            }

            throw new ArgumentException("Erro: Requisição mal sucedida.");
        }
    }
}
