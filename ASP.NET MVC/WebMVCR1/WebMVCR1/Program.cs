using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);


// Добавление сервисов в контейнер
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Конфигурация middleware и маршрутизации
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "Content")),
    RequestPath = "/Content"
});

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(configure: endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();