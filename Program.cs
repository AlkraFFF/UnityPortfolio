using UnityPortfolio.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UnityPortfolio;
using UnityPortfolio.Page;
using UnityPortfolio.Services;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient for static assets
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register the Portfolio data service
builder.Services.AddSingleton<IPortfolioService, PortfolioService>();

await builder.Build().RunAsync();
