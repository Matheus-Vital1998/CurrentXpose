using CurrentXpose.ApiService;
using CurrentXpose.ApiService.Interfaces;
using CurrentXpose.Domain.Interface;
using CurrentXpose.Domain.Services;
using CurrentXpose.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CurrentXposeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CurrentXpose"),
    builder => builder.MigrationsAssembly(typeof(CurrentXposeContext).Assembly.FullName)));

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddHttpClient<IAuthApiService, AuthApiService>(http =>
{
    http.BaseAddress = new Uri(builder.Configuration["Api:baseUrl"]);
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
