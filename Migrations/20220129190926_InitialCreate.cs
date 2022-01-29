using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RACU11.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportingPeople",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FamilyName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    Qualifier = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    Nationality = table.Column<string>(type: "TEXT", nullable: true),
                    Sex = table.Column<string>(type: "TEXT", nullable: true),
                    CivilStatus = table.Column<string>(type: "TEXT", nullable: true),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    POB = table.Column<string>(type: "TEXT", nullable: true),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: true),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: true),
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
                    HighestEducational = table.Column<string>(type: "TEXT", nullable: true),
                    Occupation = table.Column<string>(type: "TEXT", nullable: true),
                    IDCard = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportingPeople", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suspect",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FamilyName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    Qualifier = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    Nationality = table.Column<string>(type: "TEXT", nullable: true),
                    Sex = table.Column<string>(type: "TEXT", nullable: true),
                    CivilStatus = table.Column<string>(type: "TEXT", nullable: true),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: true),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: true),
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
                    RelationToVictim = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    AfpPersonnelRank = table.Column<string>(type: "TEXT", nullable: true),
                    UnitAssignment = table.Column<string>(type: "TEXT", nullable: true),
                    GroupAffiliation = table.Column<string>(type: "TEXT", nullable: true),
                    WasWithPreviousCase = table.Column<string>(type: "TEXT", nullable: true),
                    StatusOfPreviousCase = table.Column<string>(type: "TEXT", nullable: true),
                    Height = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<string>(type: "TEXT", nullable: true),
                    ColorOfEyes = table.Column<string>(type: "TEXT", nullable: true),
                    DescriptionOfEyes = table.Column<string>(type: "TEXT", nullable: true),
                    ColorOfHair = table.Column<string>(type: "TEXT", nullable: true),
                    DescriptionOfHair = table.Column<string>(type: "TEXT", nullable: true),
                    UnderInfluenceOfDrugs = table.Column<bool>(type: "INTEGER", nullable: false),
                    UnderInfluenceOfLiquors = table.Column<bool>(type: "INTEGER", nullable: false),
                    UnderInfluenceOfOthers = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspect", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IRF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlotterEntryNumber = table.Column<string>(type: "TEXT", nullable: true),
                    TypeOfIncident = table.Column<string>(type: "TEXT", nullable: true),
                    ReportingTimeAndDateOfReport = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReportingTimeAndDateOfIncident = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsThereSuspect = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsThereMoreThanOneSuspect = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReportingPersonId = table.Column<int>(type: "INTEGER", nullable: true),
                    SuspectId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IRF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IRF_ReportingPeople_ReportingPersonId",
                        column: x => x.ReportingPersonId,
                        principalTable: "ReportingPeople",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IRF_Suspect_SuspectId",
                        column: x => x.SuspectId,
                        principalTable: "Suspect",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IRF_ReportingPersonId",
                table: "IRF",
                column: "ReportingPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_IRF_SuspectId",
                table: "IRF",
                column: "SuspectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IRF");

            migrationBuilder.DropTable(
                name: "ReportingPeople");

            migrationBuilder.DropTable(
                name: "Suspect");
        }
    }
}
