using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceAutoApp.Migrations
{
    public partial class Add_New_In_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parteneriat",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    firma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    piese = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parteneriat", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parteneriat");
        }
    }
}
