using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddCihazKisiBilgileri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CihazDisParcalar");

            migrationBuilder.DropColumn(
                name: "TamirMasrafi",
                table: "Cihazlar");

            migrationBuilder.AddColumn<string>(
                name: "AlinanKisiAdSoyad",
                table: "Cihazlar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlinanKisiTelefon",
                table: "Cihazlar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SatilanKisiAdSoyad",
                table: "Cihazlar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SatilanKisiTelefon",
                table: "Cihazlar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CihazHarcamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CihazId = table.Column<int>(type: "INTEGER", nullable: false),
                    HarcamaAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: true),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CihazHarcamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CihazHarcamalar_Cihazlar_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihazlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CihazHarcamalar_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CihazHarcamalar_CihazId",
                table: "CihazHarcamalar",
                column: "CihazId");

            migrationBuilder.CreateIndex(
                name: "IX_CihazHarcamalar_UrunId",
                table: "CihazHarcamalar",
                column: "UrunId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CihazHarcamalar");

            migrationBuilder.DropColumn(
                name: "AlinanKisiAdSoyad",
                table: "Cihazlar");

            migrationBuilder.DropColumn(
                name: "AlinanKisiTelefon",
                table: "Cihazlar");

            migrationBuilder.DropColumn(
                name: "SatilanKisiAdSoyad",
                table: "Cihazlar");

            migrationBuilder.DropColumn(
                name: "SatilanKisiTelefon",
                table: "Cihazlar");

            migrationBuilder.AddColumn<decimal>(
                name: "TamirMasrafi",
                table: "Cihazlar",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "CihazDisParcalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CihazId = table.Column<int>(type: "INTEGER", nullable: false),
                    BirimMaliyet = table.Column<decimal>(type: "TEXT", nullable: false),
                    Miktar = table.Column<int>(type: "INTEGER", nullable: false),
                    ParcaAdi = table.Column<string>(type: "TEXT", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_CihazDisParcalar_CihazId",
                table: "CihazDisParcalar",
                column: "CihazId");
        }
    }
}
