using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace tetaix_circuit.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger (this IServiceCollection services)

        {
            services
                .AddSwaggerGen(setupAction =>
                {
                    setupAction.SwaggerDoc("tetaix_circuit.APIOpenSpecification", new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "tetaix_circuit.API",
                        Version = "0.1"
                    });

                    var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                    setupAction.IncludeXmlComments(xmlCommentsFullPath);
                });

            return services;
        }

        public static IApplicationBuilder UseSwaggerAsHome(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/swagger/tetaix_circuit.APIOpenSpecification/swagger.json", "Mon app NRV");
                setupAction.RoutePrefix = string.Empty;
            });

            return app;
        }
    }
}
