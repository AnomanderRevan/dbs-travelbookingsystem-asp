using TravelBookingSystemMVC.Models.Api.Transport;

namespace TravelBookingSystemMVC.Models;
public class TransportBooking
{
    public int BookingReference { get; set; }
    public int UserId { get; set; }

    public TransferOffer? TransferOffer { get; set; }
}