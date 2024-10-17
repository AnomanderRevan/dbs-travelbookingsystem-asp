using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api.Hotel
{

    public class HotelRatingResponseModel
    {
        [JsonPropertyName("data")]
        public List<HotelRating>? Data { get; set; }
    }
    public class HotelRating
    {
        [JsonPropertyName("hotelId")]
        public string? HotelId { get; set; }
        [JsonPropertyName("overallRating")]
        public int OverallRating { get; set; }
        [JsonPropertyName("numberOfReviews")]
        public int NumberOfReviews { get; set; }
        [JsonPropertyName("numberOfRatings")]
        public int NumberOfRatings { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("sentiments")]
        public Sentiments? Sentiments { get; set; }
    }



    public class Sentiments
    {
        [JsonPropertyName("staff")]
        public int Staff { get; set; }
        [JsonPropertyName("location")]
        public int Location { get; set; }
        [JsonPropertyName("service")]
        public int Service { get; set; }
        [JsonPropertyName("roomComforts")]
        public int RoomComforts { get; set; }
        [JsonPropertyName("sleepQuality")]
        public int SleepQuality { get; set; }
        [JsonPropertyName("swimmingPool")]
        public int SwimmingPool { get; set; }
        [JsonPropertyName("valueForMoney")]
        public int ValueForMoney { get; set; }
        [JsonPropertyName("facilities")]
        public int Facilities { get; set; }
        [JsonPropertyName("catering")]
        public int Catering { get; set; }
        [JsonPropertyName("pointsOfInterest")]
        public int PointsOfInterest { get; set; }
    }
}