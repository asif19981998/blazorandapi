using Blazored.LocalStorage;
using LMSClientSide.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpContextAccessor();
builder.Services.AddBlazoredLocalStorage();   // local storage
builder.Services.AddBlazoredLocalStorage(config => config.JsonSerializerOptions.WriteIndented = true);  // local storage
//builder.Services.Configure<CookiePolicyOptions>(options =>
//{
//    options.CheckConsentNeeded = context => true;
//    options.MinimumSameSitePolicy = SameSiteMode.None;
//});
//builder.Services.AddAuthentication(
//    CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie();

builder.Services.AddSingleton<WeatherForecastService>();
//builder.Services.AddHttpClient("ApiClient", client =>
//{
//    client.BaseAddress = new Uri("http://localhost:5052");
//}).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
//{
//    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
//});
builder.Services.AddHttpClient();
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
