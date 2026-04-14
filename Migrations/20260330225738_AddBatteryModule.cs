using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddBatteryModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PilLotlari_LotNo",
                table: "PilLotlari");

            migrationBuilder.DropColumn(
                name: "LotNo",
                table: "PilLotlari");

            migrationBuilder.RenameColumn(
                name: "TestTarihi",
                table: "PilLotlari",
                newName: "LotAdi");

            migrationBuilder.RenameColumn(
                name: "OrtalamaKapasite",
                table: "PilLotlari",
                newName: "GirisTarihi");

            migrationBuilder.RenameColumn(
                name: "OrtalamaIcDirenc",
                table: "PilLotlari",
                newName: "BirimMaliyet");

            migrationBuilder.AlterColumn<string>(
                name: "HucreModel",
                table: "PilLotlari",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "SifirPilMi",
                table: "PilLotlari",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TedarikciAdi",
                table: "PilLotlari",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TedarikciTelefon",
                table: "PilLotlari",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PilBataryalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BataryaAdi = table.Column<string>(type: "TEXT", nullable: false),
                    SeriSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    ParalelSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    BMSMarka = table.Column<string>(type: "TEXT", nullable: true),
                    BMSModel = table.Column<string>(type: "TEXT", nullable: true),
                    PilMaliyeti = table.Column<decimal>(type: "TEXT", nullable: false),
                    SarfMalzemeler = table.Column<decimal>(type: "TEXT", nullable: false),
                    Isçilik = table.Column<decimal>(type: "TEXT", nullable: false),
                    SatisFiyati = table.Column<decimal>(type: "TEXT", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SatisTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Durum = table.Column<string>(type: "TEXT", nullable: false),
                    Notlar = table.Column<string>(type: "TEXT", nullable: true),
                    SatilanKisiAdSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    SatilanKisiTelefon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilBataryalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PilHucres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LotId = table.Column<int>(type: "INTEGER", nullable: false),
                    SeriNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Kapasite = table.Column<decimal>(type: "TEXT", nullable: false),
                    IcDirenc = table.Column<decimal>(type: "TEXT", nullable: false),
                    Durum = table.Column<string>(type: "TEXT", nullable: false),
                    TestTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Notlar = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilHucres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PilHucres_PilLotlari_LotId",
                        column: x => x.LotId,
                        principalTable: "PilLotlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PilBataryaHucres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BataryaId = table.Column<int>(type: "INTEGER", nullable: false),
                    HucresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilBataryaHucres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PilBataryaHucres_PilBataryalar_BataryaId",
                        column: x => x.BataryaId,
                        principalTable: "PilBataryalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PilBataryaHucres_PilHucres_HucresId",
                        column: x => x.HucresId,
                        principalTable: "PilHucres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PilHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HucresId = table.Column<int>(type: "INTEGER", nullable: false),
                    HareketTipi = table.Column<string>(type: "TEXT", nullable: false),
                    Miktar = table.Column<int>(type: "INTEGER", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PilHareketleri_PilHucres_HucresId",
                        column: x => x.HucresId,
                        principalTable: "PilHucres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PilLotlari_LotAdi",
                table: "PilLotlari",
                column: "LotAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PilBataryaHucres_BataryaId",
                table: "PilBataryaHucres",
                column: "BataryaId");

            migrationBuilder.CreateIndex(
                name: "IX_PilBataryaHucres_HucresId",
                table: "PilBataryaHucres",
                column: "HucresId");

            migrationBuilder.CreateIndex(
                name: "IX_PilHareketleri_HucresId",
                table: "PilHareketleri",
                column: "HucresId");

            migrationBuilder.CreateIndex(
                name: "IX_PilHucres_LotId_SeriNo",
                table: "PilHucres",
                columns: new[] { "LotId", "SeriNo" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PilBataryaHucres");

            migrationBuilder.DropTable(
                name: "PilHareketleri");

            migrationBuilder.DropTable(
                name: "PilBataryalar");

            migrationBuilder.DropTable(
                name: "PilHucres");

            migrationBuilder.DropIndex(
                name: "IX_PilLotlari_LotAdi",
                table: "PilLotlari");

            migrationBuilder.DropColumn(
                name: "SifirPilMi",
                table: "PilLotlari");

            migrationBuilder.DropColumn(
                name: "TedarikciAdi",
                table: "PilLotlari");

            migrationBuilder.DropColumn(
                name: "TedarikciTelefon",
                table: "PilLotlari");

            migrationBuilder.RenameColumn(
                name: "LotAdi",
                table: "PilLotlari",
                newName: "TestTarihi");

            migrationBuilder.RenameColumn(
                name: "GirisTarihi",
                table: "PilLotlari",
                newName: "OrtalamaKapasite");

            migrationBuilder.RenameColumn(
                name: "BirimMaliyet",
                table: "PilLotlari",
                newName: "OrtalamaIcDirenc");

            migrationBuilder.AlterColumn<string>(
                name: "HucreModel",
                table: "PilLotlari",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LotNo",
                table: "PilLotlari",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PilLotlari_LotNo",
                table: "PilLotlari",
                column: "LotNo",
                unique: true);
        }
    }
}
