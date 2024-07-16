using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore3.Migrations
{
    /// <inheritdoc />
    public partial class ManagingImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "Games",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Games",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Games");
        }
    }
}
