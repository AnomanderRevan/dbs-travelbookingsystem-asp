namespace TravelBookingSystemMVC.Models;
public class Booking
{
    public int BookingReference { get; set; }
    public int UserId { get; set; }

    public FlightBooking? FlightBooking { get; set; }
    public HotelBooking? HotelBooking { get; set; }
    public TransportBooking? TransportBooking { get; set; }
}