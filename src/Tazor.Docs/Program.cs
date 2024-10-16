using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tazor.Components;
using Tazor.Components.App;
using Tazor.Themes.HighContrast;
using Tazor.Themes.VisualStudio;
using Tazor.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Tazor.Docs.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Inject all tazor services
// Developers may override default services by using the "With" methods
builder.Services
    .AddTazor()
    .WithInMemoryNotifications()
    .WithGravatars()
    .WithHighContrastThemes()
    .WithVisualStudioThemes()
    .Build();

var app = builder.Build();

// Apply the default theme
await app.UseTazor();

await app.RunAsync();
