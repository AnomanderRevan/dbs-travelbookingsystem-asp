using System;
using System.ComponentModel.DataAnnotations;

namespace TravelBookingSystemMVC.Models
{
    public class FlightSearchViewModel
    {
        [Required]
        [Display(Name = "Origin")]
        public required string Origin { get; set; } = "DUB";

        [Required]
        [Display(Name = "Destination")]
        public required string Destination { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Departure Date")]
        public required DateTime DepartureDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Return Date")]
        public DateTime? ReturnDate { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than or equal to {1}")]
        [Display(Name = "Adults")]
        public required int Adults { get; set; } = 1;

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value greater than or equal to {1}")]
        [Display(Name = "Children")]
        public int Children { get; set; } = 0;

        [Display(Name = "Cabin Class")]
        public string CabinClass { get; set; } = "ECONOMY";
    }
}