using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api.Hotel
{

    public class HotelOffersResponseModel
    {

        [JsonPropertyName("data")]
        public List<HotelOffer>? Data { get; set; }
    }

    public class HotelOffer
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("hotel")]
        public Hotel? Hotel { get; set; }

        [JsonPropertyName("available")]
        public bool Available { get; set; }

        [JsonPropertyName("offers")]
        public List<Offer>? Offers { get; set; }

        [JsonPropertyName("self")]
        public string? Self { get; set; }
    }

    public class Hotel
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("hotelId")]
        public string? HotelId { get; set; }

        [JsonPropertyName("chainCode")]
        public string? ChainCode { get; set; }

        [JsonPropertyName("dupeId")]
        public string? DupeId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("cityCode")]
        public string? CityCode { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }
    }

    public class Offer
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("checkInDate")]
        public string? CheckInDate { get; set; }

        [JsonPropertyName("checkOutDate")]
        public string? CheckOutDate { get; set; }

        [JsonPropertyName("rateCode")]
        public string? RateCode { get; set; }

        [JsonPropertyName("rateFamilyEstimated")]
        public RateFamilyEstimated? RateFamilyEstimated { get; set; }

        [JsonPropertyName("room")]
        public Room? Room { get; set; }

        [JsonPropertyName("guests")]
        public Guests? Guests { get; set; }

        [JsonPropertyName("price")]
        public Price? Price { get; set; }

        [JsonPropertyName("policies")]
        public Policies? Policies { get; set; }

        [JsonPropertyName("self")]
        public string? Self { get; set; }
    }

    public class RateFamilyEstimated
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class Room
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("typeEstimated")]
        public TypeEstimated? TypeEstimated { get; set; }

        [JsonPropertyName("description")]
        public Description? Description { get; set; }
    }

    public class TypeEstimated
    {
        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonPropertyName("beds")]
        public int Beds { get; set; }

        [JsonPropertyName("bedType")]
        public string? BedType { get; set; }
    }

    public class Description
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("lang")]
        public string? Lang { get; set; }
    }

    public class Guests
    {
        [JsonPropertyName("adults")]
        public int Adults { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("base")]
        public string? Base { get; set; }

        [JsonPropertyName("total")]
        public string? Total { get; set; }

        [JsonPropertyName("variations")]
        public Variations? Variations { get; set; }
    }

    public class Variations
    {
        [JsonPropertyName("average")]
        public Average? Average { get; set; }

        [JsonPropertyName("changes")]
        public List<Change>? Changes { get; set; }
    }

    public class Average
    {
        [JsonPropertyName("base")]
        public string? Base { get; set; }
    }

    public class Change
    {
        [JsonPropertyName("startDate")]
        public string? StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string? EndDate { get; set; }

        [JsonPropertyName("total")]
        public string? Total { get; set; }
    }

    public class Policies
    {
        [JsonPropertyName("cancellations")]
        public List<Cancellation>? Cancellations { get; set; }

        [JsonPropertyName("paymentType")]
        public string? PaymentType { get; set; }
    }

    public class Cancellation
    {
        [JsonPropertyName("deadline")]
        public string? Deadline { get; set; }

        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
    }
}