using CurrentXpose.ApiService;
using CurrentXpose.ApiService.Interfaces;
using CurrentXpose.Domain.Interface;
using CurrentXpose.Domain.Services;
using CurrentXpose.Infra.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CurrentXposeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CurrentXpose"),
    builder => builder.MigrationsAssembly(typeof(CurrentXposeContext).Assembly.FullName)));

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddHttpClient<IAuthApiService, AuthApiService>(http =>
{
    http.BaseAddress = new Uri(builder.Configuration["Api:baseUrl"]);
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index";
        options.AccessDeniedPath = "/Login/AcessoNegado";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
    });

builder.Services.AddAuthorization();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Cache-Control", "no-cache, no-store, must-revalidate");
    context.Response.Headers.Add("Pragma", "no-cache");
    context.Response.Headers.Add("Expires", "0");
    await next();
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Login}/{action=Index}/{id?}");
    endpoints.MapControllers();
});

app.UseHsts();
app.Run();