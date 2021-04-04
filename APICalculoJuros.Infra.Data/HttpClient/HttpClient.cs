using APICalculoJuros.Domain.Interfaces.infra.HttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Infra.Data.HttpClient
{
    public class HttpClient : IHttpClient
    {
        private readonly System.Net.Http.HttpClient httpClient;

        public HttpClient()
        {
            this.httpClient = new System.Net.Http.HttpClient();
        }

        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await this.httpClient.SendAsync(httpRequestMessage);

            return response;
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string uri, T item)
        {
            return await DoRequestAsync(HttpMethod.Post, uri, item);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string uri, T item)
        {
            return await DoRequestAsync(HttpMethod.Put, uri, item);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);
            var response = await this.httpClient.SendAsync(httpRequestMessage);

            return response;
        }

        private async Task<HttpResponseMessage> DoRequestAsync<T>(HttpMethod httpMethod, string uri, T item)
        {
            var httpRequestMessage = new HttpRequestMessage(httpMethod, uri)
            {
                Content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json")
            };

            var response = await this.httpClient.SendAsync(httpRequestMessage);

            return response;
        }
    }

}
