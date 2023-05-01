using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext() { }
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) 
        {
            
        }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Luxury Resort",
                    Ranking = 4,
                    Description = "This luxury resort is the perfect destination for travelers seeking an indulgent and rejuvenating vacation experience. Nestled in a picturesque setting, the resort offers world-class amenities and services, including a spa, fitness center, and gourmet dining options. Guests can unwind in the comfortable and elegantly furnished rooms, which feature stunning views of the surrounding landscape. Whether you're looking for a romantic getaway or a family vacation, this resort has something for everyone.",
                    Location = "Bali, Indonesia",
                    Rooms = 200,
                    Phone = "01 797 678",
                    ImageUrl = "https://media.istockphoto.com/id/104731717/photo/luxury-resort.jpg?s=612x612&w=0&k=20&c=cODMSPbYyrn1FHake1xYz9M8r15iOfGz9Aosy9Db7mI="
                },
                new Hotel
                {
                    Id = 2,
                    Name = "St. Regis Dubai",
                    Ranking = 5,
                    Description = "The St. Regis Dubai is a true gem of the Middle East, offering guests an unparalleled level of luxury and sophistication. Boasting an impressive array of amenities and services, this hotel is the perfect choice for discerning travelers seeking an unforgettable experience. From the stunning architecture to the exquisite interior design, every aspect of this hotel exudes elegance and refinement. Whether you're indulging in a gourmet meal at one of the hotel's restaurants or lounging by the pool, you're sure to feel pampered and relaxed.",
                    Location = "Dubai, UAE",
                    Rooms = 150,
                    Phone = "01 035 538",
                    ImageUrl = "https://samchui.com/wp-content/uploads/2018/07/St-Regis-Dubai-Luxury-Hotel-in-Dubai-Exterior-Shot.jpg"
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel Continental",
                    Ranking = 3,
                    Description = "This chic and modern hotel offers a refreshing take on traditional hospitality, blending contemporary design with impeccable service. With its prime location and extensive range of amenities, the hotel is the ideal choice for travelers seeking convenience and comfort. From the stylishly appointed rooms to the well-equipped fitness center, every aspect of this hotel is designed with the guest's comfort in mind. Whether you're in town for business or leisure, this hotel offers a perfect home away from home.",
                    Location = "Paris, France",
                    Rooms = 100,
                    Phone = "01 004 278",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/106257638.jpg?k=4dd13a3f0f19081704cd50ee377462f2d13ea0662e577576e98bedc711005334&o=&hp=1"
                }
            );
        }
    }
}