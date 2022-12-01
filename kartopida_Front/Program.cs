using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq ;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor ;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorCRUDApp.Client.Auth;
// using kartopida_FRONT.Auth ;

namespace kartopida_FRONT
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<JWTAuthenticationProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationProvider>(provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            builder.Services.AddScoped<ILoginService, JWTAuthenticationProvider>(provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            // builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            // builder.Services.AddScoped<IAuthService, ClerkAuthService>();
        
            builder.RootComponents.Add<App>("app");
            // builder.Services.AddSingleton<IAuthService , ClerkAuthService>();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjg5ODQ0QDMxMzgyZTMyMmUzMG5JeHBDaFhWWC8xelpGRE1ubm5iYVRPdGxjaVQzcWxRQndISElzRkZrSGs9");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();

            
        }
    }
}   
