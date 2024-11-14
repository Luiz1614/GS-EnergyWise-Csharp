using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GS_EnergyWise.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GS1_Comunidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TamanhoArea = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    UnidadeArea = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Populacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GS1_Comunidade", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GS1_Comunidade");
        }
    }
}
