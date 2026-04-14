using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddStockMovementDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeriNoTakip",
                table: "Urunler");

            migrationBuilder.AddColumn<string>(
                name: "AlinanNumara",
                table: "Urunler",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlinanYer",
                table: "Urunler",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CihazId",
                table: "StokHareketleri",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriAdi",
                table: "StokHareketleri",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriTelefon",
                table: "StokHareketleri",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TedarikciAdi",
                table: "StokHareketleri",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TedarikciTelefon",
                table: "StokHareketleri",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlinanNumara",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "AlinanYer",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "CihazId",
                table: "StokHareketleri");

            migrationBuilder.DropColumn(
                name: "MusteriAdi",
                table: "StokHareketleri");

            migrationBuilder.DropColumn(
                name: "MusteriTelefon",
                table: "StokHareketleri");

            migrationBuilder.DropColumn(
                name: "TedarikciAdi",
                table: "StokHareketleri");

            migrationBuilder.DropColumn(
                name: "TedarikciTelefon",
                table: "StokHareketleri");

            migrationBuilder.AddColumn<bool>(
                name: "SeriNoTakip",
                table: "Urunler",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
