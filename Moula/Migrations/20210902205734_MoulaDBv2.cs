using Microsoft.EntityFrameworkCore.Migrations;

namespace Moula.Migrations
{
    public partial class MoulaDBv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "Transactions",
                newName: "Status");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Transactions",
                newName: "Reason");

            migrationBuilder.AddColumn<byte>(
                name: "IsClosed",
                table: "Transactions",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
