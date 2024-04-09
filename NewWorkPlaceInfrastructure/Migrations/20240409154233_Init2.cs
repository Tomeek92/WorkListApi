using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewWorkPlaceInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisterToFindJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterEmailToFindJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterPasswordToFindJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterTimeToFindJob = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterToFindJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterToTakeJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterEmailToTakeJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterPasswordToTakeJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterPhoneNumberToTakeJob = table.Column<int>(type: "int", nullable: false),
                    RegisterNameToTakeJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterAddressToTakeJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterTimeToTakeJob = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterToTakeJobs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterToFindJobs");

            migrationBuilder.DropTable(
                name: "RegisterToTakeJobs");
        }
    }
}
