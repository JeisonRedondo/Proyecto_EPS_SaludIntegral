using Microsoft.EntityFrameworkCore.Migrations;

namespace SaludIntegral.App.Persistencia.Migrations
{
    public partial class Inicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Personas",
                newName: "Last_name");

            migrationBuilder.AddColumn<bool>(
                name: "Contributive",
                table: "Personas",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id_patient",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Particular",
                table: "Personas",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contributive",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Id_patient",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Particular",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "Last_name",
                table: "Personas",
                newName: "last_name");
        }
    }
}
