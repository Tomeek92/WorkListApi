using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewWorkPlaceInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListOfWorkToFindJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Money = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfWorkToFindJobs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListOfWorkToFindJobs");
        }
    }
}
