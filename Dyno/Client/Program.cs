using Dyno.Shared.AppUtility;
using Dyno.Shared.AppUtility.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dyno.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // add services for app
            AddAppServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void AddAppServices(IServiceCollection services)
        {
            services.AddMudServices();
            services.AddSingleton<IClientState, ClientState>();
        }
    }
}
