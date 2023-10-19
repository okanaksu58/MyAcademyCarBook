using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyCarBook.DataAccessLayer.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BrandName",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BrandID1",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_BrandID1",
                table: "Brands",
                column: "BrandID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Brands_BrandID1",
                table: "Brands",
                column: "BrandID1",
                principalTable: "Brands",
                principalColumn: "BrandID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Brands_BrandID1",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_BrandID1",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "BrandID1",
                table: "Brands");

            migrationBuilder.AlterColumn<int>(
                name: "BrandName",
                table: "Brands",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
