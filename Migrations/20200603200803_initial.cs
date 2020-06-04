using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Guestbook.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    RecordId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nick = table.Column<string>(nullable: false),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.RecordId);
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "RecordId", "Comment", "Country", "DatePosted", "Email", "Nick" },
                values: new object[,]
                {
                    { 1, "first comment", "poland", new DateTime(2020, 6, 3, 22, 8, 2, 964, DateTimeKind.Local).AddTicks(4868), "xxx@gmail.com", "starczi" },
                    { 2, "second comment", "universe", new DateTime(2020, 6, 3, 22, 8, 2, 970, DateTimeKind.Local).AddTicks(7936), "yyy@gmail.com", "starczi1" },
                    { 3, "third comment", "europe", new DateTime(2020, 6, 3, 22, 8, 2, 970, DateTimeKind.Local).AddTicks(8233), "zzz@gmail.com", "starczi2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
