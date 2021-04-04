using APICalculoJuros.Application.Calculo;
using APICalculoJuros.Application.Interfaces.Calculo;
using APICalculoJuros.Application.Interfaces.ShowMeTheCode;
using APICalculoJuros.Application.Services.Calculo;
using APICalculoJuros.Application.Services.ShowMeTheCode;
using APICalculoJuros.Domain.Interfaces.Calculo;
using APICalculoJuros.Domain.Interfaces.infra.HttpClient;
using APICalculoJuros.Domain.Interfaces.ShowMeTheCode;
using APICalculoJuros.Domain.Service.Calculo;
using APICalculoJuros.Domain.Service.ShowMeTheCode;
using APICalculoJuros.Infra.Data.HttpClient;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace APICalculoJuros.Infra.CrossCutting
{
    public static class IOC
    {
        public static void AddInjecaoDependencia(this IServiceCollection services) 
        {
            services.AddTransient<ICalculoAppService, CalculoAppService>();
            services.AddTransient<ICalculoService, CalculoService>();
            services.AddTransient<IShowMeTheCodeAppService, ShowMeTheCodeAppService>();
            services.AddTransient<IShowMeTheCodeService, ShowMeTheCodeService>();
            services.AddTransient<IHttpClient, HttpClient>();
        }
    }
}
