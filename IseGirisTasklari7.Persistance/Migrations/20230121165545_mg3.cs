using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IseGirisTasklari7.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderFinishTime",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "OrderStartTime",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "OrderFinishTimeHour",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderFinishTimeMinute",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderStartTimeHour",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderStartTimeMinute",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderFinishTimeHour",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "OrderFinishTimeMinute",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "OrderStartTimeHour",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "OrderStartTimeMinute",
                table: "Companies");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "OrderFinishTime",
                table: "Companies",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "OrderStartTime",
                table: "Companies",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
