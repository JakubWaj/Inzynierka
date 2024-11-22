using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class XDDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Countries_CountryId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Countries_CountryId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_CountryId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_CountryId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Reviews");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CountryId",
                table: "Roles",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CountryId",
                table: "Reviews",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Countries_CountryId",
                table: "Reviews",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Countries_CountryId",
                table: "Roles",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
