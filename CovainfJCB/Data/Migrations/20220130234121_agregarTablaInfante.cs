using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovainfJCB.Data.Migrations
{
    public partial class agregarTablaInfante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infantes",
                columns: table => new
                {
                    IdInfante = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NombresInfante = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ApellidosInfante = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdRepresentante = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infantes", x => x.IdInfante);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infantes");
        }
    }
}
