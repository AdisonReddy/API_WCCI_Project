using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InnovaDiscs.Migrations
{
    /// <inheritdoc />
    public partial class DiscGolfMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscGolfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Team = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscGolfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SpeedInt = table.Column<int>(type: "int", nullable: false),
                    GlideInt = table.Column<int>(type: "int", nullable: false),
                    TurnInt = table.Column<int>(type: "int", nullable: false),
                    FadeInt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DiscGolfers",
                columns: new[] { "Id", "FirstName", "LastName", "Team" },
                values: new object[] { 1, "Adison", "Reddy", "Innova" });

            migrationBuilder.InsertData(
                table: "Discs",
                columns: new[] { "Id", "Brand", "FadeInt", "GlideInt", "Name", "SpeedInt", "TurnInt", "Type" },
                values: new object[,]
                {
                    { 1, "Innova", 3, 5, "Destroyer", 12, -1, "Distance Driver" },
                    { 2, "Innova", 2, 5, "Teebird", 7, 0, "Fairway Driver" },
                    { 3, "Innova", 3, 2, "Toro", 4, 1, "Midrange" },
                    { 4, "Discmania", 1, 3, "Link", 2, 0, "Putter" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscGolfers");

            migrationBuilder.DropTable(
                name: "Discs");
        }
    }
}
