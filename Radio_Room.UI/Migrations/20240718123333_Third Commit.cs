using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Radio_Room.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<int>(
                name: "PlayerResponseOption",
                table: "Dialogues",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dialogues",
                table: "Dialogues",
                column: "DialogueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<int>(
                name: "PlayerResponseOption",
                table: "dialogues",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_dialogues",
                table: "dialogues",
                column: "DialogueId");
        }
    }
}
