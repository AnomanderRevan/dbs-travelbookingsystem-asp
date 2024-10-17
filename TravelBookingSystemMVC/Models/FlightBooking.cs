using TravelBookingSystemMVC.Models.Api.Flight;

namespace TravelBookingSystemMVC.Models;
public class FlightBooking
{
    public int BookingReference { get; set; }
    public int UserId { get; set; }

    public FlightOffer? FlightOffer { get; set; }
}