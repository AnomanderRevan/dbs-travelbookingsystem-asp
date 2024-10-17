using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api;

public class OAuthResponseModel
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }
}