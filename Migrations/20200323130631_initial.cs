using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LinqCollection.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Romantic Comedy", 7.99m, new DateTime(1446, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "When Harry Met Sally" },
                    { 2, "Comedy", 8.99m, new DateTime(1441, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghostbusters " },
                    { 3, "Comedy", 9.99m, new DateTime(1443, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghostbusters 2" },
                    { 4, "Western", 3.99m, new DateTime(1416, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rio Bravo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
