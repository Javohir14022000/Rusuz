using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rusuz.Migrations
{
    /// <inheritdoc />
    public partial class TwoMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Words",
                newName: "WordPicture");

            migrationBuilder.AddColumn<string>(
                name: "English",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTrans",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExampleEng",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExampleUz",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uzbek",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SectionPicture",
                table: "Sektions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Star",
                table: "Sektions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Star",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "English",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "EnglishTrans",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "ExampleEng",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "ExampleUz",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "Uzbek",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "SectionPicture",
                table: "Sektions");

            migrationBuilder.DropColumn(
                name: "Star",
                table: "Sektions");

            migrationBuilder.DropColumn(
                name: "Star",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "WordPicture",
                table: "Words",
                newName: "Name");
        }
    }
}
