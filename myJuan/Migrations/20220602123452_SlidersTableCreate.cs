using Microsoft.EntityFrameworkCore.Migrations;

namespace myJuan.Migrations
{
    public partial class SlidersTableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(maxLength: 35, nullable: true),
                    Title2 = table.Column<string>(maxLength: 35, nullable: true),
                    Desc = table.Column<string>(maxLength: 250, nullable: true),
                    Btntext = table.Column<string>(maxLength: 35, nullable: true),
                    BtnUrl = table.Column<string>(maxLength: 200, nullable: true),
                    Image = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
