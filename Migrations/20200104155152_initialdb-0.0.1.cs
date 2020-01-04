using Microsoft.EntityFrameworkCore.Migrations;

namespace BallGame.Migrations
{
    public partial class initialdb001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Environs",
                columns: table => new
                {
                    EnvID = table.Column<string>(nullable: false),
                    EnvName = table.Column<string>(nullable: true),
                    EnvLocation = table.Column<string>(nullable: true),
                    EnvTurfType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environs", x => x.EnvID);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<string>(nullable: false),
                    PlayerName = table.Column<string>(nullable: true),
                    PlayerRassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Environs");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
