using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<EventEase.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//registro i servizi
builder.Services.AddSingleton<SharedService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<EventService>();
builder.Services.AddSingleton<LocalStorageService>();
builder.Services.AddSingleton<NotificationService>();

 

await builder.Build().RunAsync();
