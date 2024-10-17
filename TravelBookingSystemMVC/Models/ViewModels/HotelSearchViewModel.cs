using System;
using System.ComponentModel.DataAnnotations;

namespace TravelBookingSystemMVC.Models
{
    public class HotelSearchViewModel
    {
        [Required]
        [Display(Name = "City")]
        public required string City { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Check-In Date")]
        public required DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check-Out Date Date")]
        public required DateTime CheckOutDate { get; set; }

        [Display(Name = "Room Type")]
        public string RoomType { get; set; } = "DOUBLE";
    }
}