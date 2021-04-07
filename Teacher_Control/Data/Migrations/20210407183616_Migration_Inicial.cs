using Microsoft.EntityFrameworkCore.Migrations;

namespace Teacher_Control.Data.Migrations
{
    public partial class Migration_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Inscripcions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Inscripcions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
