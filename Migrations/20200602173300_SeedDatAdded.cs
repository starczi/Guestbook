using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestbook.Migrations
{
    public partial class SeedDatAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "RecordId", "Comment", "Country", "DatePosted", "Email", "Nick" },
                values: new object[,]
                {
                    { 1, "first comment", "poland", new DateTime(2020, 6, 2, 19, 32, 59, 733, DateTimeKind.Local).AddTicks(3745), "xxx@gmail.com", "starczi" },
                    { 2, "second comment", "universe", new DateTime(2020, 6, 2, 19, 32, 59, 737, DateTimeKind.Local).AddTicks(8564), "yyy@gmail.com", "starczi1" },
                    { 3, "third comment", "europe", new DateTime(2020, 6, 2, 19, 32, 59, 737, DateTimeKind.Local).AddTicks(8783), "zzz@gmail.com", "starczi2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: 3);
        }
    }
}
