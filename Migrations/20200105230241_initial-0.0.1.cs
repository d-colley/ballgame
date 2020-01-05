using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BallGameMVC.Migrations
{
    public partial class initial001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Environ",
                columns: table => new
                {
                    EnvID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnvName = table.Column<string>(nullable: true),
                    EnvLocation = table.Column<string>(nullable: true),
                    EnvTurfType = table.Column<string>(nullable: true),
                    EnvRegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environ", x => x.EnvID);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(nullable: true),
                    PlayerRassword = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Environ");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
