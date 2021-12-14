using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo5s.Migrations
{
    public partial class ws : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_ReptileModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReptileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReptileNode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ReptileModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_ReptileModel");
        }
    }
}
