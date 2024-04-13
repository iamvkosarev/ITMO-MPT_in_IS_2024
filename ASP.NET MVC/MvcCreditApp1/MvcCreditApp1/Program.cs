using Microsoft.EntityFrameworkCore;
using MvcCreditApp1.Models;
using System.Data.Entity;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebOptimizer(pipeline =>
{
    pipeline.AddJavaScriptBundle("~/bundles/jquery", "Scripts/jquery-{version}.js");
    pipeline.AddJavaScriptBundle("~/bundles/ajax", "Scripts/jquery.unobtrusive-ajax.min.js");
});
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    // Настройте здесь другие параметры Identity
})
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

Database.SetInitializer(new CreditsDbInitializer());

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

