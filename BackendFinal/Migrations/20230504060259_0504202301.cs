using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendFinal.Migrations
{
    public partial class _0504202301 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Appid",
                table: "Donators",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timeslot = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Docid = table.Column<int>(type: "int", nullable: true),
                    Lid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_Docid",
                        column: x => x.Docid,
                        principalTable: "Doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Locations_Lid",
                        column: x => x.Lid,
                        principalTable: "Locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donators_Appid",
                table: "Donators",
                column: "Appid");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Docid",
                table: "Appointments",
                column: "Docid");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Lid",
                table: "Appointments",
                column: "Lid");

            migrationBuilder.AddForeignKey(
                name: "FK_Donators_Appointments_Appid",
                table: "Donators",
                column: "Appid",
                principalTable: "Appointments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donators_Appointments_Appid",
                table: "Donators");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Donators_Appid",
                table: "Donators");

            migrationBuilder.DropColumn(
                name: "Appid",
                table: "Donators");
        }
    }
}
