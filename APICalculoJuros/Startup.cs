using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICalculoJuros.Application.Calculo;
using APICalculoJuros.Domain.Service.Calculo;
using APICalculoJuros.Domain.Service.ShowMeTheCode;
using APICalculoJuros.Infra.CrossCutting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace APICalculoJuros
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddInjecaoDependencia();

            services.AddSwaggerGen(options =>
                {
                    options.SwaggerDoc("v1", 
                        new OpenApiInfo
                        {
                            Title = "Calculo de Juros",
                            Description = "Api responsável por realizar um equação consumindo outra api para utilizar suas propriedades de Juros.",
                            Version = "v1",
                            Contact = new OpenApiContact 
                            { 
                                Name = "Luiz Fernando Junoir.",
                                Email = "luizfernandojr1998@gmail.com"
                            }
                        }
                    );
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerUI(su =>
            {
                su.RoutePrefix = "Swagger";
                su.SwaggerEndpoint("/swagger/v1/swagger.json", "CalculoJuros API");
            });

            app.UseSwagger();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
