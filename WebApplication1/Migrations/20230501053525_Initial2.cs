using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "This luxury resort is the perfect destination for travelers seeking an indulgent and rejuvenating vacation experience. Nestled in a picturesque setting, the resort offers world-class amenities and services, including a spa, fitness center, and gourmet dining options. Guests can unwind in the comfortable and elegantly furnished rooms, which feature stunning views of the surrounding landscape. Whether you're looking for a romantic getaway or a family vacation, this resort has something for everyone.");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The St. Regis Dubai is a true gem of the Middle East, offering guests an unparalleled level of luxury and sophistication. Boasting an impressive array of amenities and services, this hotel is the perfect choice for discerning travelers seeking an unforgettable experience. From the stunning architecture to the exquisite interior design, every aspect of this hotel exudes elegance and refinement. Whether you're indulging in a gourmet meal at one of the hotel's restaurants or lounging by the pool, you're sure to feel pampered and relaxed.");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "This chic and modern hotel offers a refreshing take on traditional hospitality, blending contemporary design with impeccable service. With its prime location and extensive range of amenities, the hotel is the ideal choice for travelers seeking convenience and comfort. From the stylishly appointed rooms to the well-equipped fitness center, every aspect of this hotel is designed with the guest's comfort in mind. Whether you're in town for business or leisure, this hotel offers a perfect home away from home.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A luxurious resort with world-class amenities.");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A luxurious hotel with stunning views of Dubai.");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A cozy hotel with great service and comfortable rooms.");
        }
    }
}
