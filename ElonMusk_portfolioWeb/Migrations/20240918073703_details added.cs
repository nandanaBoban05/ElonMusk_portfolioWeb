using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElonMusk_portfolioWeb.Migrations
{
    /// <inheritdoc />
    public partial class detailsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "DetailId", "Email", "Occupation", "Phone" },
                values: new object[] { 1, "elonmusk@gmail.com", "Ceo of SpaceX", "9541366558" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "DetailId",
                keyValue: 1);
        }
    }
}
