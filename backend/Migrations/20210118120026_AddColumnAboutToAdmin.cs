using Microsoft.EntityFrameworkCore.Migrations;

namespace SnailTailBlog.WebApi.Migrations
{
    public partial class AddColumnAboutToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Admins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Admins");
        }
    }
}
