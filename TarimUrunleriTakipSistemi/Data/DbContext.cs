using Microsoft.EntityFrameworkCore;
using TarimUrunleruTakipSistemi.Models;
 // Urunler modelinin olduğu namespace

namespace TarimUrunleruTakipSistemi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet tanımlamaları
        public DbSet<Adresler> Adresler { get; set; }
        public DbSet<Sahipler> Sahipler { get; set; }
        public DbSet<AraziTurleri> AraziTurleri { get; set; }
        public DbSet<Ciftlikler> Ciftlikler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Birimler> Birimler { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Hasatlar> Hasatlar { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<Siparisler> Siparisler { get; set; }
        public DbSet<Satislar> Satislar { get; set; }
        public DbSet<Soforler> Soforler { get; set; }
        public DbSet<LojistikDurumlari> LojistikDurumlari { get; set; }
        public DbSet<Araclar> Araclar { get; set; }
        public DbSet<Lojistik> Lojistik { get; set; }
        public DbSet<Roller> Roller { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }

        // Model yapılandırmaları ve ilişkiler
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Örnek: Siparisler ve Musteriler arasında ilişki
            modelBuilder.Entity<Siparisler>()
                .HasOne(s => s.Musteri)
                .WithMany(m => m.Siparisler)
                .HasForeignKey(s => s.MusteriID);

            // Örnek: Urunler ve Kategoriler arasında ilişki
            modelBuilder.Entity<Urunler>()
                .HasOne(u => u.Kategori)
                .WithMany(k => k.Urunler)
                .HasForeignKey(u => u.KategoriID);

            // Örnek: Test verileri ekleme
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { Id= 1, Ad = "Sebze" },
                new Kategori { Id = 2, Ad = "Meyve" }
            );

            modelBuilder.Entity<Urunler>().HasData(
                new Urunler { Id = 1, Ad = "Elma", BirimFiyati = 10, StokMiktari = 100, KategoriID = 2 },
                new Urunler { Id = 2, Ad = "Domates", BirimFiyati = 8, StokMiktari = 200, KategoriID = 1 }
            );
        }
    }
}
