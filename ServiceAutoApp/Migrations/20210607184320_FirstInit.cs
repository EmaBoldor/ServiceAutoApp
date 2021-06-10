using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceAutoApp.Migrations
{
    public partial class FirstInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locatia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipDefectiune = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipMasina = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Masina",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipMasina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locatia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masina", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Serviciu",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DenumireServiciu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pret = table.Column<double>(type: "float", nullable: false),
                    TipMasinaNecesara = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serviciu", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ID", "Locatia", "Nume", "Prenume", "TipDefectiune", "TipMasina" },
                values: new object[,]
                {
                    { new Guid("551e9dab-b73e-4322-8200-bfab4a214d9f"), "Campani", "Boldor", "Ema", "pana la roata", "vw" },
                    { new Guid("551e9dab-b73e-4322-2345-bfab4a214d9a"), "Campani", "Boldor", "Sara", "oglina rupta", "audi" }
                });

            migrationBuilder.InsertData(
                table: "Masina",
                columns: new[] { "ID", "Locatia", "TipMasina" },
                values: new object[,]
                {
                    { new Guid("551e9dab-b73e-1233-2345-bfab4a214d9a"), "Oradea", "duba" },
                    { new Guid("551e9dab-b73e-4567-2345-bfab4a214d9a"), "Bistrita", "tir" }
                });

            migrationBuilder.InsertData(
                table: "Serviciu",
                columns: new[] { "ID", "DenumireServiciu", "Pret", "TipMasinaNecesara" },
                values: new object[,]
                {
                    { new Guid("551e9dab-b73e-4567-2345-bfab4a214d9a"), "vulcanizare", 1234.0, "duba" },
                    { new Guid("551e9dab-b73e-6789-2345-bfab4a214d9a"), "avariere", 1345.0, "tir" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Masina");

            migrationBuilder.DropTable(
                name: "Serviciu");
        }
    }
}
