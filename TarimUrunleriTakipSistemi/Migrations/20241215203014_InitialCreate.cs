using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TarimUrunleriTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    AdresID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eyalet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sokak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BinaNo = table.Column<int>(type: "int", nullable: false),
                    DaireNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.AdresID);
                });

            migrationBuilder.CreateTable(
                name: "Araclar",
                columns: table => new
                {
                    AracID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kapasite = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araclar", x => x.AracID);
                });

            migrationBuilder.CreateTable(
                name: "AraziTurleri",
                columns: table => new
                {
                    AraziTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AraziTurleri", x => x.AraziTuruID);
                });

            migrationBuilder.CreateTable(
                name: "Birimler",
                columns: table => new
                {
                    BirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimler", x => x.BirimID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LojistikDurumlari",
                columns: table => new
                {
                    DurumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LojistikDurumlari", x => x.DurumID);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresID = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.MusteriID);
                    table.ForeignKey(
                        name: "FK_Musteriler_Adresler_AdresID",
                        column: x => x.AdresID,
                        principalTable: "Adresler",
                        principalColumn: "AdresID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sahipler",
                columns: table => new
                {
                    SahipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresID = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sahipler", x => x.SahipID);
                    table.ForeignKey(
                        name: "FK_Sahipler_Adresler_AdresID",
                        column: x => x.AdresID,
                        principalTable: "Adresler",
                        principalColumn: "AdresID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Soforler",
                columns: table => new
                {
                    SoforID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresID = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EhliyetSinifi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soforler", x => x.SoforID);
                    table.ForeignKey(
                        name: "FK_Soforler_Adresler_AdresID",
                        column: x => x.AdresID,
                        principalTable: "Adresler",
                        principalColumn: "AdresID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    BirimID = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StokMiktari = table.Column<int>(type: "int", nullable: false),
                    BirimFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Birimler_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birimler",
                        principalColumn: "BirimID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolID = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Roller_RolID",
                        column: x => x.RolID,
                        principalTable: "Roller",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciftlikler",
                columns: table => new
                {
                    CiftlikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SahipID = table.Column<int>(type: "int", nullable: false),
                    AraziTuruID = table.Column<int>(type: "int", nullable: false),
                    AdresID = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buyukluk = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciftlikler", x => x.CiftlikID);
                    table.ForeignKey(
                        name: "FK_Ciftlikler_Adresler_AdresID",
                        column: x => x.AdresID,
                        principalTable: "Adresler",
                        principalColumn: "AdresID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ciftlikler_AraziTurleri_AraziTuruID",
                        column: x => x.AraziTuruID,
                        principalTable: "AraziTurleri",
                        principalColumn: "AraziTuruID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ciftlikler_Sahipler_SahipID",
                        column: x => x.SahipID,
                        principalTable: "Sahipler",
                        principalColumn: "SahipID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.SiparisID);
                    table.ForeignKey(
                        name: "FK_Siparisler_Musteriler_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteriler",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hasatlar",
                columns: table => new
                {
                    HasatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiftlikID = table.Column<int>(type: "int", nullable: false),
                    BirimID = table.Column<int>(type: "int", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hasatlar", x => x.HasatID);
                    table.ForeignKey(
                        name: "FK_Hasatlar_Birimler_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birimler",
                        principalColumn: "BirimID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hasatlar_Ciftlikler_CiftlikID",
                        column: x => x.CiftlikID,
                        principalTable: "Ciftlikler",
                        principalColumn: "CiftlikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hasatlar_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satislar",
                columns: table => new
                {
                    SatisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satislar", x => x.SatisID);
                    table.ForeignKey(
                        name: "FK_Satislar_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "SiparisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lojistik",
                columns: table => new
                {
                    LojistikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoforID = table.Column<int>(type: "int", nullable: false),
                    SatisID = table.Column<int>(type: "int", nullable: false),
                    AracID = table.Column<int>(type: "int", nullable: false),
                    DurumID = table.Column<int>(type: "int", nullable: false),
                    TahiminiTeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojistik", x => x.LojistikID);
                    table.ForeignKey(
                        name: "FK_Lojistik_Araclar_AracID",
                        column: x => x.AracID,
                        principalTable: "Araclar",
                        principalColumn: "AracID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lojistik_LojistikDurumlari_DurumID",
                        column: x => x.DurumID,
                        principalTable: "LojistikDurumlari",
                        principalColumn: "DurumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lojistik_Satislar_SatisID",
                        column: x => x.SatisID,
                        principalTable: "Satislar",
                        principalColumn: "SatisID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lojistik_Soforler_SoforID",
                        column: x => x.SoforID,
                        principalTable: "Soforler",
                        principalColumn: "SoforID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Aciklama", "Ad", "OlusturmaTarihi" },
                values: new object[,]
                {
                    { 1, null, "Sebze", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, "Meyve", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Ad", "BirimFiyati", "BirimID", "KategoriID", "StokMiktari" },
                values: new object[,]
                {
                    { 1, "Elma", 10m, 0, 2, 100 },
                    { 2, "Domates", 8m, 0, 1, 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciftlikler_AdresID",
                table: "Ciftlikler",
                column: "AdresID");

            migrationBuilder.CreateIndex(
                name: "IX_Ciftlikler_AraziTuruID",
                table: "Ciftlikler",
                column: "AraziTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_Ciftlikler_SahipID",
                table: "Ciftlikler",
                column: "SahipID");

            migrationBuilder.CreateIndex(
                name: "IX_Hasatlar_BirimID",
                table: "Hasatlar",
                column: "BirimID");

            migrationBuilder.CreateIndex(
                name: "IX_Hasatlar_CiftlikID",
                table: "Hasatlar",
                column: "CiftlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Hasatlar_UrunID",
                table: "Hasatlar",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_RolID",
                table: "Kullanicilar",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_Lojistik_AracID",
                table: "Lojistik",
                column: "AracID");

            migrationBuilder.CreateIndex(
                name: "IX_Lojistik_DurumID",
                table: "Lojistik",
                column: "DurumID");

            migrationBuilder.CreateIndex(
                name: "IX_Lojistik_SatisID",
                table: "Lojistik",
                column: "SatisID");

            migrationBuilder.CreateIndex(
                name: "IX_Lojistik_SoforID",
                table: "Lojistik",
                column: "SoforID");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_AdresID",
                table: "Musteriler",
                column: "AdresID");

            migrationBuilder.CreateIndex(
                name: "IX_Sahipler_AdresID",
                table: "Sahipler",
                column: "AdresID");

            migrationBuilder.CreateIndex(
                name: "IX_Satislar_SiparisID",
                table: "Satislar",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MusteriID",
                table: "Siparisler",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_UrunID",
                table: "Siparisler",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Soforler_AdresID",
                table: "Soforler",
                column: "AdresID");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BirimID",
                table: "Urunler",
                column: "BirimID");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriID",
                table: "Urunler",
                column: "KategoriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hasatlar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Lojistik");

            migrationBuilder.DropTable(
                name: "Ciftlikler");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Araclar");

            migrationBuilder.DropTable(
                name: "LojistikDurumlari");

            migrationBuilder.DropTable(
                name: "Satislar");

            migrationBuilder.DropTable(
                name: "Soforler");

            migrationBuilder.DropTable(
                name: "AraziTurleri");

            migrationBuilder.DropTable(
                name: "Sahipler");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "Birimler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
