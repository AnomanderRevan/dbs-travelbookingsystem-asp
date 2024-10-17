using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api.Flight;

public class AirlineCodeLookupResponseModel
{

    public class Airline
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("iataCode")]
        public string? IataCode { get; set; }
        [JsonPropertyName("icaoCode")]
        public string? IcaoCode { get; set; }
        [JsonPropertyName("businessName")]
        public string? BusinessName { get; set; }
        [JsonPropertyName("commonName")]
        public string? CommonName { get; set; }

    }

    [JsonPropertyName("data")]
    public List<Airline>? Data { get; set; }
}