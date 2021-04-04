using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APICalculoJuros.Domain.Interfaces.infra.HttpClient
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> GetAsync(string uri);

        Task<HttpResponseMessage> PostAsync<T>(string uri, T item);

        Task<HttpResponseMessage> PutAsync<T>(string uri, T item);

        Task<HttpResponseMessage> DeleteAsync(string uri);
    }
}
