using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoykoyYapanlaraDestek.v2.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adresi = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Il = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CocaColaYok = table.Column<bool>(type: "bit", nullable: false),
                    AlgidaYok = table.Column<bool>(type: "bit", nullable: false),
                    MapSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enlem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boylam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "Marka");
        }
    }
}
