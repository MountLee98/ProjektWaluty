using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WindowsProjekt
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //IServiceCollection services;
            //var services = new ServiceCollection();

            //services.AddCors(options =>
            //{
            //    this defines a cors policy called "default"
            //    options.AddPolicy("default", policy =>
            //    {
            //        policy.WithOrigins("http://localhost:3000")
            //            .AllowAnyHeader()
            //            .AllowAnyMethod();
            //    });
            //});


            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();

        }
    }
}
