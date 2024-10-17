using TravelBookingSystemMVC.Models.Api.Hotel;

namespace TravelBookingSystemMVC.Models;
public class HotelBooking
{
    public int BookingReference { get; set; }
    public int UserId { get; set; }

    public HotelOffer? HotelOffer { get; set; }
}