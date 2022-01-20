using Microsoft.EntityFrameworkCore.Migrations;

namespace BitirmeProjesiWeb.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "noor@gmail.com", "NOOR NOOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "yazanalkhatib956@gmail.com", "Yazan ALKHATIB" });
        }
    }
}
