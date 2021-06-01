using Microsoft.EntityFrameworkCore.Migrations;

namespace tetaix_circuit.Migrations
{
    public partial class PrixVoiture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pack");

            migrationBuilder.DropTable(
                name: "Circuit");

            migrationBuilder.AddColumn<int>(
                name: "prix",
                table: "Voiture",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prix",
                table: "Voiture");

            migrationBuilder.CreateTable(
                name: "Circuit",
                columns: table => new
                {
                    CircuitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    etat_circuit = table.Column<int>(type: "int", nullable: false),
                    nom_circuit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre_km = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuit", x => x.CircuitId);
                });

            migrationBuilder.CreateTable(
                name: "Pack",
                columns: table => new
                {
                    PackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CircuitId = table.Column<int>(type: "int", nullable: false),
                    VoitureId = table.Column<int>(type: "int", nullable: false),
                    nb_tour = table.Column<int>(type: "int", nullable: false),
                    nom_pack = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pack", x => x.PackId);
                    table.ForeignKey(
                        name: "FK_Pack_Circuit_CircuitId",
                        column: x => x.CircuitId,
                        principalTable: "Circuit",
                        principalColumn: "CircuitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pack_Voiture_VoitureId",
                        column: x => x.VoitureId,
                        principalTable: "Voiture",
                        principalColumn: "VoitureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pack_CircuitId",
                table: "Pack",
                column: "CircuitId");

            migrationBuilder.CreateIndex(
                name: "IX_Pack_VoitureId",
                table: "Pack",
                column: "VoitureId");
        }
    }
}
