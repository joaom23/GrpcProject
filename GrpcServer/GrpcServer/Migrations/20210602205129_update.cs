using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrpcServer.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estrelas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estrela1 = table.Column<int>(nullable: false),
                    Estrela2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estrelas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Numeros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero1 = table.Column<int>(nullable: false),
                    Numero2 = table.Column<int>(nullable: false),
                    Numero3 = table.Column<int>(nullable: false),
                    Numero4 = table.Column<int>(nullable: false),
                    Numero5 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numeros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apostas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumerosId = table.Column<int>(nullable: false),
                    EstrelasId = table.Column<int>(nullable: false),
                    DataAposta = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apostas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apostas_Estrelas_EstrelasId",
                        column: x => x.EstrelasId,
                        principalTable: "Estrelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apostas_Numeros_NumerosId",
                        column: x => x.NumerosId,
                        principalTable: "Numeros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apostas_EstrelasId",
                table: "Apostas",
                column: "EstrelasId");

            migrationBuilder.CreateIndex(
                name: "IX_Apostas_NumerosId",
                table: "Apostas",
                column: "NumerosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apostas");

            migrationBuilder.DropTable(
                name: "Estrelas");

            migrationBuilder.DropTable(
                name: "Numeros");
        }
    }
}
