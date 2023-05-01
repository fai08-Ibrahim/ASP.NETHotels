using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please rate our Hotel from one to 5 stars!")]
        [Range(1, 5,  ErrorMessage = "Ranking must be between 1 and 5")]
        public int Ranking { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please add the Hotel's location!")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Please enter the number of rooms available!")]
        public int? Rooms { get; set; }

        [Required(ErrorMessage = "Please add a link to the Hotel's image!")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Please Enter your Phone Number!")]
        public string? Phone { get; set; }
    }
}
