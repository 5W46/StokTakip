using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddProductPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OrtalamaIcDirenc",
                table: "PilBataryalar",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OrtalamaKapasite",
                table: "PilBataryalar",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ToplamIcDirenc",
                table: "PilBataryalar",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ToplamKapasite",
                table: "PilBataryalar",
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
                    ParcaAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Miktar = table.Column<int>(type: "INTEGER", nullable: false),
                    BirimMaliyet = table.Column<decimal>(type: "TEXT", nullable: false),
                    ToplamMaliyet = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CihazDisParcalar");

            migrationBuilder.DropColumn(
                name: "OrtalamaIcDirenc",
                table: "PilBataryalar");

            migrationBuilder.DropColumn(
                name: "OrtalamaKapasite",
                table: "PilBataryalar");

            migrationBuilder.DropColumn(
                name: "ToplamIcDirenc",
                table: "PilBataryalar");

            migrationBuilder.DropColumn(
                name: "ToplamKapasite",
                table: "PilBataryalar");
        }
    }
}
