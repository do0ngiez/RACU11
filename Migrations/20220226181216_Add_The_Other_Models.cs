using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RACU11.Migrations
{
    public partial class Add_The_Other_Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChildrenId",
                table: "IRF",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VictimId",
                table: "IRF",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuardianName = table.Column<string>(type: "TEXT", nullable: true),
                    GuardianAddress = table.Column<string>(type: "TEXT", nullable: true),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: true),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: true),
                    DiversionMechanism = table.Column<string>(type: "TEXT", nullable: true),
                    OtherFeatures = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Victim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IfReportingPersonIsVictim = table.Column<bool>(type: "INTEGER", nullable: false),
                    IfTwoOrMoreVictims = table.Column<bool>(type: "INTEGER", nullable: false),
                    FamilyName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    Qualifier = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentAddress = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentVillage = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentBarangay = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentCity = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentProvince = table.Column<string>(type: "TEXT", nullable: true),
                    OtherAddress = table.Column<string>(type: "TEXT", nullable: true),
                    OtherVillage = table.Column<string>(type: "TEXT", nullable: true),
                    OtherBarangay = table.Column<string>(type: "TEXT", nullable: true),
                    OtherCity = table.Column<string>(type: "TEXT", nullable: true),
                    OtherProvince = table.Column<string>(type: "TEXT", nullable: true),
                    HighestEducation = table.Column<string>(type: "TEXT", nullable: true),
                    Occupation = table.Column<string>(type: "TEXT", nullable: true),
                    WorkAddress = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Victim", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IRF_ChildrenId",
                table: "IRF",
                column: "ChildrenId");

            migrationBuilder.CreateIndex(
                name: "IX_IRF_VictimId",
                table: "IRF",
                column: "VictimId");

            migrationBuilder.AddForeignKey(
                name: "FK_IRF_Children_ChildrenId",
                table: "IRF",
                column: "ChildrenId",
                principalTable: "Children",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IRF_Victim_VictimId",
                table: "IRF",
                column: "VictimId",
                principalTable: "Victim",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IRF_Children_ChildrenId",
                table: "IRF");

            migrationBuilder.DropForeignKey(
                name: "FK_IRF_Victim_VictimId",
                table: "IRF");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Victim");

            migrationBuilder.DropIndex(
                name: "IX_IRF_ChildrenId",
                table: "IRF");

            migrationBuilder.DropIndex(
                name: "IX_IRF_VictimId",
                table: "IRF");

            migrationBuilder.DropColumn(
                name: "ChildrenId",
                table: "IRF");

            migrationBuilder.DropColumn(
                name: "VictimId",
                table: "IRF");
        }
    }
}
