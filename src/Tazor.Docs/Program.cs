using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tazor.ServiceModel;
using Tazor.Services;
using Tazor.Components;
using Tazor.Components.App;
using Tazor.Themes.HighContrast;
using Tazor.Themes.VisualStudio;
using Tazor.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Tazor.Docs.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAvatarProvider, GravatarAvatarProvider>();

builder.Services
    .AddTazor()
    .WithInMemoryNotifications()
    .WithHighContrastThemes()
    .WithVisualStudioThemes()
    .Build();

var app = builder.Build();

await app.UseTazor();
await app.RunAsync();
