using APICalculoJuros.Domain.Interfaces.infra.HttpClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace APICalculoJuros.Test.Services.Calculo
{
    public class CalculoServiceTest
    {
        private const string uri = "https://localhost:44350/api/v1/taxajuros";

        [Theory]
        [InlineData(HttpStatusCode.OK)]
        public async Task TesteChamadaApiTaxaJurosAsync(HttpStatusCode resultado)
        {
            var httpClient = new System.Net.Http.HttpClient();

            var retornoHttpMessage = await httpClient.GetAsync(uri).ConfigureAwait(false);
            retornoHttpMessage.EnsureSuccessStatusCode();

            var status = retornoHttpMessage.StatusCode;

            Assert.Equal(status, resultado);
        }

        [Theory]
        [InlineData(0.01)]
        public async Task TesteRetornoChamadaApiTaxaJurosAsync(decimal resultado)
        {
            var httpClient = new System.Net.Http.HttpClient();

            var retornoHttpMessage = await httpClient.GetAsync(uri).ConfigureAwait(false);
            if (retornoHttpMessage.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<decimal>(await retornoHttpMessage.Content.ReadAsStringAsync().ConfigureAwait(false));

                Assert.Equal(result, resultado);
            }
        }
    }
}
