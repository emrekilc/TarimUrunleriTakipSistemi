using Microsoft.EntityFrameworkCore;
using TarimUrunleruTakipSistemi.Data;

var builder = WebApplication.CreateBuilder(args);

// Veritaban� ba�lant�s�n� ve DbContext yap�land�rmas�n� ekliyoruz.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC hizmetlerini ekliyoruz.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Geli�tirme s�ras�nda hata sayfas�n� etkinle�tirelim.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsay�lan rota yap�land�rmas�
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
