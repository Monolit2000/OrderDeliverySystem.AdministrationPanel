using OrderDeliverySystem.AdministrationPanel.Components;
using OrderDeliverySystem.AdministrationPanel.Services.Catalog;
using OrderDeliverySystem.AdministrationPanel.Services.Contracts;
using OrderDeliverySystem.AdministrationPanel.Services.Order;
using MatBlazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMatBlazor();

builder.Services.AddScoped(sp => new HttpClient() /*{ BaseAddress = new Uri(builder.Configuration["OrderDeliverySystemServiceUrl"]) }*/);

builder.Services.AddScoped<ICatalogService, CatalogService>();

builder.Services.AddScoped<IOrderService, OrderService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
