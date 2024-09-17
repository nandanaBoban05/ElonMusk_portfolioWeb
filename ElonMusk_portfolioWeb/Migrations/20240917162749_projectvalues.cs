using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElonMusk_portfolioWeb.Migrations
{
    /// <inheritdoc />
    public partial class projectvalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "DetailId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Cybertruck: Tesla's all-electric Cybertruck is set to begin production,with Musk highlighting its durability and futuristic design.\r\nThe vehicle aims to disrupt the traditional truck market with its unique features and electric powertrain.", "https://wallpaperaccess.com/full/846579.jpg", "Tesla" },
                    { 2, "Starship: SpaceX is actively working on Starship, a fully reusable spacecraft designed for missions to Mars and beyond. The spacecraft aims to make space travel more affordable and sustainable. Test flights and development are ongoing, with plans for operational missions in the near future.\r\n", "https://i.pinimg.com/736x/b6/12/2e/b6122e067cad4cde07468d6627544989.jpg", "SpaceX" },
                    { 3, "Brain-Computer Interfaces: Neuralink is working on advanced brain-computer interface technologies. The company aims to develop devices that can treat neurological conditions and eventually enable direct communication between the human brain and computers.", "https://th.bing.com/th/id/R.1e3159c54758a954464cdfe581cc387a?rik=HMGyr2Hl2hcBqg&riu=http%3a%2f%2fstatic1.squarespace.com%2fstatic%2f61422d4c713a6811602aa6b0%2ft%2f6151f784a101dd20189704a4%2f1632761732961%2fNeurolink%2blogo.jpg%3fformat%3d1500w&ehk=aYcTvTWshEucBV4Xn0jNeBM0HKq2wTwfx4HQfJlx0xA%3d&risl=&pid=ImgRaw&r=0", "Neuralink" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "DetailId", "Email", "Occupation", "Phone" },
                values: new object[] { 1, "elonmusk@example.com", "CEO of SpaceX, Tesla, etc.", "1234567890" });
        }
    }
}
