using Microsoft.EntityFrameworkCore.Migrations;

namespace tetaix_circuit.Migrations
{
    public partial class voituredescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Voiture",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Voiture");
        }
    }
}
