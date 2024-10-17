using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api.Hotel;

public class HotelListByCityResponseModel
{
    public class Hotel
    {
        [JsonPropertyName("chainCode")]
        public string? ChainCode { get; set; }

        [JsonPropertyName("iataCode")]
        public string? IataCode { get; set; }
        [JsonPropertyName("hotelId")]
        public string? HotelId { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("geoCode")]
        public GeoCode? GeoCode { get; set; }
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
    }


    public class GeoCode
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }
    }
}