using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddCihazModelleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cihazlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MarkaModel = table.Column<string>(type: "TEXT", nullable: false),
                    SeriNo = table.Column<string>(type: "TEXT", nullable: false),
                    Durum = table.Column<string>(type: "TEXT", nullable: false),
                    AlisMaliyeti = table.Column<decimal>(type: "TEXT", nullable: false),
                    TamirMasrafi = table.Column<decimal>(type: "TEXT", nullable: false),
                    SatisFiyati = table.Column<decimal>(type: "TEXT", nullable: false),
                    Notlar = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SatisTarihi = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cihazlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Giderler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GiderTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Kategori = table.Column<string>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giderler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    Soyad = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PilLotlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LotNo = table.Column<string>(type: "TEXT", nullable: false),
                    HucreModel = table.Column<string>(type: "TEXT", nullable: false),
                    Adet = table.Column<int>(type: "INTEGER", nullable: false),
                    OrtalamaKapasite = table.Column<decimal>(type: "TEXT", nullable: false),
                    OrtalamaIcDirenc = table.Column<decimal>(type: "TEXT", nullable: false),
                    TestTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Notlar = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilLotlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barkod = table.Column<string>(type: "TEXT", nullable: true),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: false),
                    AlisFiyati = table.Column<decimal>(type: "TEXT", nullable: false),
                    SatisFiyati = table.Column<decimal>(type: "TEXT", nullable: false),
                    StokMiktari = table.Column<int>(type: "INTEGER", nullable: false),
                    MinStok = table.Column<int>(type: "INTEGER", nullable: false),
                    SeriNoTakip = table.Column<bool>(type: "INTEGER", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CihazDisParcalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CihazId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParcaAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Miktar = table.Column<int>(type: "INTEGER", nullable: false),
                    BirimMaliyet = table.Column<decimal>(type: "TEXT", nullable: false),
                    ToplamMaliyet = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CihazDisParcalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CihazDisParcalar_Cihazlar_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihazlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CihazYapilacaklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CihazId = table.Column<int>(type: "INTEGER", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    Tamamlandi = table.Column<bool>(type: "INTEGER", nullable: false),
                    Sira = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CihazYapilacaklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CihazYapilacaklar_Cihazlar_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihazlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satislar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MusteriId = table.Column<int>(type: "INTEGER", nullable: false),
                    SatisTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KargoTakipNo = table.Column<string>(type: "TEXT", nullable: true),
                    Notlar = table.Column<string>(type: "TEXT", nullable: true),
                    ToplamTutar = table.Column<decimal>(type: "TEXT", nullable: false),
                    OdemeDurumu = table.Column<string>(type: "TEXT", nullable: false),
                    Indirim = table.Column<decimal>(type: "TEXT", nullable: true),
                    KargoUcreti = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satislar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satislar_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StokHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false),
                    HareketTipi = table.Column<string>(type: "TEXT", nullable: false),
                    Miktar = table.Column<int>(type: "INTEGER", nullable: false),
                    OncekiStok = table.Column<int>(type: "INTEGER", nullable: false),
                    SonrakiStok = table.Column<int>(type: "INTEGER", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokHareketleri_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatisDetaylari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SatisId = table.Column<int>(type: "INTEGER", nullable: false),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false),
                    Miktar = table.Column<int>(type: "INTEGER", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    ToplamFiyat = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisDetaylari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatisDetaylari_Satislar_SatisId",
                        column: x => x.SatisId,
                        principalTable: "Satislar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisDetaylari_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CihazDisParcalar_CihazId",
                table: "CihazDisParcalar",
                column: "CihazId");

            migrationBuilder.CreateIndex(
                name: "IX_Cihazlar_SeriNo",
                table: "Cihazlar",
                column: "SeriNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CihazYapilacaklar_CihazId_Sira",
                table: "CihazYapilacaklar",
                columns: new[] { "CihazId", "Sira" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PilLotlari_LotNo",
                table: "PilLotlari",
                column: "LotNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SatisDetaylari_SatisId",
                table: "SatisDetaylari",
                column: "SatisId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisDetaylari_UrunId",
                table: "SatisDetaylari",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Satislar_MusteriId",
                table: "Satislar",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketleri_UrunId",
                table: "StokHareketleri",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_Barkod",
                table: "Urunler",
                column: "Barkod",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CihazDisParcalar");

            migrationBuilder.DropTable(
                name: "CihazYapilacaklar");

            migrationBuilder.DropTable(
                name: "Giderler");

            migrationBuilder.DropTable(
                name: "PilLotlari");

            migrationBuilder.DropTable(
                name: "SatisDetaylari");

            migrationBuilder.DropTable(
                name: "StokHareketleri");

            migrationBuilder.DropTable(
                name: "Cihazlar");

            migrationBuilder.DropTable(
                name: "Satislar");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
