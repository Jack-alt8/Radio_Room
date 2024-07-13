using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Radio_Room.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerResponseOption",
                table: "dialogues",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerResponseOption",
                table: "dialogues");
        }
    }
}
