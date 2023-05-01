using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ranking = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Description", "ImageUrl", "Location", "Name", "Ranking", "Rooms" },
                values: new object[,]
                {
                    { 1, "A luxurious resort with world-class amenities.", "https://media.istockphoto.com/id/104731717/photo/luxury-resort.jpg?s=612x612&w=0&k=20&c=cODMSPbYyrn1FHake1xYz9M8r15iOfGz9Aosy9Db7mI=", "Bali, Indonesia", "Luxury Resort", 4, 200 },
                    { 2, "A luxurious hotel with stunning views of Dubai.", "https://samchui.com/wp-content/uploads/2018/07/St-Regis-Dubai-Luxury-Hotel-in-Dubai-Exterior-Shot.jpg", "Dubai, UAE", "St. Regis Dubai", 5, 150 },
                    { 3, "A cozy hotel with great service and comfortable rooms.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/106257638.jpg?k=4dd13a3f0f19081704cd50ee377462f2d13ea0662e577576e98bedc711005334&o=&hp=1", "Paris, France", "Hotel Continental", 3, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
