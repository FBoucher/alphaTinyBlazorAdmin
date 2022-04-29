using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Cloud5mins.TinyBlazorAdmin;
//using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });

// // set up a delegate to get function token
// static string functionEndpoint(WebAssemblyHostBuilder builder) =>
//     builder.Configuration
//         .GetSection(nameof(UrlShortenerSecuredService))
//         .GetValue<string>(nameof(AzFuncAuthorizationMessageHandler.Endpoint));

// //Add SycnFusion Controls
// Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzgwNjM5QDMxMzgyZTMzMmUzMGhPbXloTFpmTVFQTEgrMUZ2NjZONkFEZmhLOG16RkhYSkYyZmZpOHRVUkU9"); 
// builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
