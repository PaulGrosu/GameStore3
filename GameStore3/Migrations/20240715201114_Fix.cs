using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore3.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Games");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Games",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
