using ASP.Plugins.InMemory;
using ASP.UseCases.Akashi_Inventories;
using ASP.UseCases.Akashi_PluginInterfaces;
using ASP.UseCases.Inventories;
using ASP.UseCases.PluginInterfaces;
using ASP.UseCases.Products;
using ASP.WebApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//ims
builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();
builder.Services.AddTransient<IViewInventoriesByNameUseCase, ViewInventoriesByNameUseCase>();
builder.Services.AddTransient<IAddInventoryUseCase, AddInventoryUseCase>();
builder.Services.AddTransient<IEditInventoryUseCase, EditInventoryUseCase>();
builder.Services.AddTransient<IViewInventoryByIdUseCase, ViewInventoryByIdUseCase>();

builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IViewProductsByNameUseCase, ViewProductsByNameUseCase>();

//akashi shop
builder.Services.AddSingleton<IWaifuRepository, WaifuRepository>();
builder.Services.AddTransient<IShipWaifu_name, ShipWaifu_name>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
