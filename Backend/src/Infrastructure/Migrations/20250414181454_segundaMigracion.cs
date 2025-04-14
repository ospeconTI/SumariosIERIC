using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class segundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Inspectores",
                table: "Inspectores");

            migrationBuilder.RenameTable(
                name: "Inspectores",
                newName: "Inspector",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inspector",
                schema: "dbo",
                table: "Inspector",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Legajos",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentificadorIMR = table.Column<int>(type: "int", nullable: false),
                    CUIT = table.Column<long>(type: "bigint", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAsignacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Estado = table.Column<string>(type: "varchar", precision: 100, nullable: true),
                    LegacyId = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legajos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Legajos_Inspector_InspectorId",
                        column: x => x.InspectorId,
                        principalSchema: "dbo",
                        principalTable: "Inspector",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Actas",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DomicilioNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomicilioCalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomicilioBarrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomicilioLocalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomicilioProvincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomicilioCodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomicilioPais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaControl = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadObreros = table.Column<int>(type: "int", nullable: false),
                    LegajoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LegacyId = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actas_Legajos_LegajoId",
                        column: x => x.LegajoId,
                        principalSchema: "dbo",
                        principalTable: "Legajos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actas_LegajoId",
                schema: "dbo",
                table: "Actas",
                column: "LegajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Legajos_InspectorId",
                schema: "dbo",
                table: "Legajos",
                column: "InspectorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Legajos",
                schema: "dbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inspector",
                schema: "dbo",
                table: "Inspector");

            migrationBuilder.RenameTable(
                name: "Inspector",
                schema: "dbo",
                newName: "Inspectores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inspectores",
                table: "Inspectores",
                column: "Id");
        }
    }
}
