using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DynamicChartDashboard.Migrations
{
    /// <inheritdoc />
    public partial class Databasesetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    SalesAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SalesData",
                columns: new[] { "Id", "Month", "MonthNumber", "SalesAmount", "Year" },
                values: new object[,]
                {
                    { 1, "January", 1, 98000m, 2024 },
                    { 2, "February", 2, 112000m, 2024 },
                    { 3, "March", 3, 135000m, 2024 },
                    { 4, "April", 4, 128000m, 2024 },
                    { 5, "May", 5, 142000m, 2024 },
                    { 6, "June", 6, 155000m, 2024 },
                    { 7, "July", 7, 148000m, 2024 },
                    { 8, "August", 8, 162000m, 2024 },
                    { 9, "September", 9, 158000m, 2024 },
                    { 10, "October", 10, 175000m, 2024 },
                    { 11, "November", 11, 188000m, 2024 },
                    { 12, "December", 12, 210000m, 2024 },
                    { 13, "January", 1, 110000m, 2025 },
                    { 14, "February", 2, 128000m, 2025 },
                    { 15, "March", 3, 152000m, 2025 },
                    { 16, "April", 4, 140000m, 2025 },
                    { 17, "May", 5, 160000m, 2025 },
                    { 18, "June", 6, 172000m, 2025 },
                    { 19, "July", 7, 168000m, 2025 },
                    { 20, "August", 8, 185000m, 2025 },
                    { 21, "September", 9, 178000m, 2025 },
                    { 22, "October", 10, 198000m, 2025 },
                    { 23, "November", 11, 215000m, 2025 },
                    { 24, "December", 12, 245000m, 2025 },
                    { 25, "January", 1, 125000m, 2026 },
                    { 26, "February", 2, 145000m, 2026 },
                    { 27, "March", 3, 168000m, 2026 },
                    { 28, "April", 4, 152000m, 2026 },
                    { 29, "May", 5, 175000m, 2026 },
                    { 30, "June", 6, 190000m, 2026 },
                    { 31, "July", 7, 185000m, 2026 },
                    { 32, "August", 8, 210000m, 2026 },
                    { 33, "September", 9, 198000m, 2026 },
                    { 34, "October", 10, 225000m, 2026 },
                    { 35, "November", 11, 240000m, 2026 },
                    { 36, "December", 12, 275000m, 2026 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesData");
        }
    }
}
