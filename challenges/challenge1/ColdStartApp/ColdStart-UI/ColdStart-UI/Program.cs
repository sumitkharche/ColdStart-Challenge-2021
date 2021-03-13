using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AzureStaticWebApps.Blazor.Authentication;
using Blazored.Toast;

namespace ColdStart_UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            var baseAddress = builder.Configuration["BaseAddress"] ?? builder.HostEnvironment.BaseAddress;
            builder.Services
                .AddTransient(sp => new HttpClient { BaseAddress = new Uri(baseAddress) })
                .AddStaticWebAppsAuthentication()
                .AddBlazoredToast();

            await builder.Build().RunAsync();
        }
    }
}
