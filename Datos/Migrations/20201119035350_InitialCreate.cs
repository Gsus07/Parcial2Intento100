using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPago = table.Column<string>(maxLength: 10, nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false),
                    ValorIva = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terceros",
                columns: table => new
                {
                    Identificacion = table.Column<string>(maxLength: 10, nullable: false),
                    TipoIdentificacion = table.Column<string>(maxLength: 5, nullable: true),
                    Nombre = table.Column<string>(maxLength: 20, nullable: true),
                    TipoTercero = table.Column<string>(maxLength: 15, nullable: true),
                    Direccion = table.Column<string>(maxLength: 15, nullable: true),
                    Telefono = table.Column<string>(maxLength: 2, nullable: true),
                    Pais = table.Column<string>(maxLength: 15, nullable: true),
                    Departamento = table.Column<string>(maxLength: 15, nullable: true),
                    Ciudad = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terceros", x => x.Identificacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Terceros");
        }
    }
}
