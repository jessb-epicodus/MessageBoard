using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class ReconfigureModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMessage");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RoomMessage",
                columns: table => new
                {
                    RoomMessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomMessage", x => x.RoomMessageId);
                    table.ForeignKey(
                        name: "FK_RoomMessage_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomMessage_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId1",
                table: "Messages",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_RoomMessage_MessageId",
                table: "RoomMessage",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomMessage_RoomId",
                table: "RoomMessage",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId1",
                table: "Messages",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId1",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "RoomMessage");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId1",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Messages");

            migrationBuilder.CreateTable(
                name: "UserMessage",
                columns: table => new
                {
                    UserMessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessage", x => x.UserMessageId);
                    table.ForeignKey(
                        name: "FK_UserMessage_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMessage_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserMessage_MessageId",
                table: "UserMessage",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessage_UserId",
                table: "UserMessage",
                column: "UserId");
        }
    }
}
