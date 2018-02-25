using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IwantToEarn.services.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cash = table.Column<double>(type: "money", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    JobTitle = table.Column<string>(type: "nchar(20)", maxLength: 25, nullable: false),
                    WhereIsJob = table.Column<string>(type: "nchar(20)", maxLength: 20, nullable: false),
                    ForHourOrWholeJob = table.Column<int>(type: "bit", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobModels");
        }
    }
}
