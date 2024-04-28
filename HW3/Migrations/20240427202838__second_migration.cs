using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW4.Migrations
{
    /// <inheritdoc />
    public partial class _second_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FriendAge",
                table: "Friend",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FriendAge",
                table: "Friend");
        }
    }
}
