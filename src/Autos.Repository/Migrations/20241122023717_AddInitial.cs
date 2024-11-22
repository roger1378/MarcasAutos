using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Autos.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "MarcasAutos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Marca = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    Modelo = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    Anno = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Serial = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcasAutos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MarcasAutos",
                columns: new[] { "Id", "Anno", "Color", "IsActive", "Marca", "Modelo", "Serial" },
                values: new object[,]
                {
                    { new Guid("395f18a0-fa4f-4731-8eb6-75954189499a"), 2021, "Rojo", true, "Toyota", "Corolla", "1234567890" },
                    { new Guid("5a1e6b51-09cc-4d59-8f57-7a5fee10de08"), 2024, "Azul", true, "Toyota", "Camry", "1234567891" },
                    { new Guid("ccaa5951-e864-40e1-b801-a41e1470dff5"), 2024, "Blanco", true, "Toyota", "Rav4", "1234567892" },
                    { new Guid("d8b86b65-7e9c-4046-a21e-b57eb47e2fba"), 2025, "Blanco", true, "Ford", "Raptor", "1234567892" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarcasAutos");
        }
    }
}
