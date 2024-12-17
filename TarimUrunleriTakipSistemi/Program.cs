using Microsoft.EntityFrameworkCore;
using TarimUrunleruTakipSistemi.Data;

var builder = WebApplication.CreateBuilder(args);

// Veritabaný baðlantýsýný ve DbContext yapýlandýrmasýný ekliyoruz.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC hizmetlerini ekliyoruz.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Geliþtirme sýrasýnda hata sayfasýný etkinleþtirelim.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsayýlan rota yapýlandýrmasý
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
