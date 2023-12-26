using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proba3.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Proba3Context>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Proba3Context") ?? throw new InvalidOperationException("Connection string 'Proba3Context' not found.")));

// Add services to the container.
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(options => options.LoginPath = "/");
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseAuthorization();
app.UseAuthentication();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
