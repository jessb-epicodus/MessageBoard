using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomMessage_Messages_MessageId",
                table: "RoomMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomMessage_Rooms_RoomId",
                table: "RoomMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomMessage",
                table: "RoomMessage");

            migrationBuilder.RenameTable(
                name: "RoomMessage",
                newName: "RoomMessages");

            migrationBuilder.RenameIndex(
                name: "IX_RoomMessage_RoomId",
                table: "RoomMessages",
                newName: "IX_RoomMessages_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomMessage_MessageId",
                table: "RoomMessages",
                newName: "IX_RoomMessages_MessageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomMessages",
                table: "RoomMessages",
                column: "RoomMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomMessages_Messages_MessageId",
                table: "RoomMessages",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomMessages_Rooms_RoomId",
                table: "RoomMessages",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomMessages_Messages_MessageId",
                table: "RoomMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomMessages_Rooms_RoomId",
                table: "RoomMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomMessages",
                table: "RoomMessages");

            migrationBuilder.RenameTable(
                name: "RoomMessages",
                newName: "RoomMessage");

            migrationBuilder.RenameIndex(
                name: "IX_RoomMessages_RoomId",
                table: "RoomMessage",
                newName: "IX_RoomMessage_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomMessages_MessageId",
                table: "RoomMessage",
                newName: "IX_RoomMessage_MessageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomMessage",
                table: "RoomMessage",
                column: "RoomMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomMessage_Messages_MessageId",
                table: "RoomMessage",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomMessage_Rooms_RoomId",
                table: "RoomMessage",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
