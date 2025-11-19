using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC367.Migrations
{
    /// <inheritdoc />
    public partial class AddMaDaiLy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TenDaiLy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaDaiLy = table.Column<string>(type: "TEXT", nullable: true),
                    TenDaiLy = table.Column<string>(type: "TEXT", nullable: true),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: true),
                    NguoiDaiDien = table.Column<string>(type: "TEXT", nullable: true),
                    DienThoai = table.Column<string>(type: "TEXT", nullable: true),
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenDaiLy", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TenDaiLy");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Person");
        }
    }
}
