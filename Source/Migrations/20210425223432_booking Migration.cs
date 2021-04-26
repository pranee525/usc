﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewService.Migrations
{
    public partial class bookingMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Bookings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Bookings");
        }
    }
}
