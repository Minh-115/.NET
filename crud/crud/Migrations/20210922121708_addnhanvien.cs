using Microsoft.EntityFrameworkCore.Migrations;

namespace crud.Migrations
{
    public partial class addnhanvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nhanvien",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    vitri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    luong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanvien", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nhanvien");
        }
    }
}
