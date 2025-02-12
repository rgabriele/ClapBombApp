using ClapBomb.Client.Pages;
using ClapBomb.Components;
using MudBlazor.Services;
using ClapBomb.Services;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddHttpClient();

builder.Services.AddHttpClient("NHLWebAPI", c =>
{
    c.BaseAddress = new Uri(builder.Configuration.GetValue<string>("NHLWebAPI"));
});

builder.Services.AddHttpClient("NHLStatsAPI", c =>
{
    c.BaseAddress = new Uri(builder.Configuration.GetValue<string>("NHLStatsAPI"));
});

builder.Services.AddSingleton<TeamService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(ClapBomb.Client._Imports).Assembly);

app.Run();
