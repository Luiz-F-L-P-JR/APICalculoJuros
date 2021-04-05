using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace APICalculoJuros.Test.Services.TesteClientProvider
{
    public class TesteClientProvider 
    {
        public HttpClient Client { get; private set; }

        public TesteClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
