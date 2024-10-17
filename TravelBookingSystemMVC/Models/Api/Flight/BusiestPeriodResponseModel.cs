using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api.Flight;

public class BusiestPeriodResponseModel
{
    public class Travelers
    {
        [JsonPropertyName("score")]
        public int Score { get; set; }
    }

    public class Analytics
    {
        [JsonPropertyName("travelers")]
        public Travelers? Travelers { get; set; }
    }

    public class Item
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("period")]
        public string? Period { get; set; }
        [JsonPropertyName("analytics")]
        public Analytics? Analytics { get; set; }
        public int score => Analytics?.Travelers?.Score ?? 0;
    }

    [JsonPropertyName("data")]
    public List<Item>? Data { get; set; }
}