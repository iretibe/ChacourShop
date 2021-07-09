using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChacourShop.EmailAPI.Migrations
{
    public partial class AddedEmailTablesToEmailDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Log = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailSent = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailLogs");
        }
    }
}
