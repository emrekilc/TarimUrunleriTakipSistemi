using Microsoft.EntityFrameworkCore;
using TarimUrunleruTakipSistemi.Data;

var builder = WebApplication.CreateBuilder(args);

// Veritabanı bağlantısını ve DbContext yapılandırmasını ekliyoruz.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC hizmetlerini ekliyoruz.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Geliştirme sırasında hata sayfasını etkinleştirelim.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsayılan rota yapılandırması
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
