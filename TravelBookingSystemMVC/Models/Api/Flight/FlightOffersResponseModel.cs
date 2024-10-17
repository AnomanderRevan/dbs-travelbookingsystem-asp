using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api.Flight
{
    public class FlightOffersResponseModel
    {
        [JsonPropertyName("data")]
        public List<FlightOffer>? Data { get; set; }
    }

    public class FlightOffer
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("source")]
        public string? Source { get; set; }

        [JsonPropertyName("instantTicketingRequired")]
        public bool InstantTicketingRequired { get; set; }

        [JsonPropertyName("nonHomogeneous")]
        public bool NonHomogeneous { get; set; }

        [JsonPropertyName("oneWay")]
        public bool OneWay { get; set; }

        [JsonPropertyName("lastTicketingDate")]
        public string? LastTicketingDate { get; set; }

        [JsonPropertyName("numberOfBookableSeats")]
        public int NumberOfBookableSeats { get; set; }

        [JsonPropertyName("itineraries")]
        public List<Itinerary>? Itineraries { get; set; }

        [JsonPropertyName("price")]
        public Price? Price { get; set; }

        [JsonPropertyName("pricingOptions")]
        public PricingOptions? PricingOptions { get; set; }

        [JsonPropertyName("validatingAirlineCodes")]
        public List<string>? ValidatingAirlineCodes { get; set; }

        [JsonPropertyName("travelerPricings")]
        public List<TravelerPricing>? TravelerPricings { get; set; }

        // Computed property to get the duration of the first itinerary (outbound)
        public string? FlightDuration => Itineraries?.ElementAtOrDefault(0)?.Duration;

        // Computed property to get the price of the first traveler pricing
        public string? TotalPrice => Price?.Total;

        // Computed property to get the Flight Number
        public string? FlightNumber => Itineraries?.ElementAtOrDefault(0)?.Segments?.ElementAtOrDefault(0)?.CarrierCode + "-" + Itineraries?.ElementAtOrDefault(0)?.Segments?.ElementAtOrDefault(0)?.Number;

        // Computed property to get the Outbound flight departure time
        public DateTime? DepartureTime => Itineraries?.ElementAtOrDefault(0)?.Segments?.ElementAtOrDefault(0)?.Departure?.At;

        // Computed property to get the Outbound flight arrival time
        public DateTime? ArrivalTime => Itineraries?.ElementAtOrDefault(0)?.Segments?.ElementAtOrDefault(0)?.Arrival?.At;

        // Computed property to get the Cabin class
        public string? CabinClass => TravelerPricings?.ElementAtOrDefault(0)?.FareDetailsBySegment?.ElementAtOrDefault(0)?.Cabin;


    }

    public class Itinerary
    {
        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("segments")]
        public List<Segment>? Segments { get; set; }
    }

    public class Segment
    {
        [JsonPropertyName("departure")]
        public Departure? Departure { get; set; }

        [JsonPropertyName("arrival")]
        public Arrival? Arrival { get; set; }

        [JsonPropertyName("carrierCode")]
        public string? CarrierCode { get; set; }

        [JsonPropertyName("number")]
        public string? Number { get; set; }

        [JsonPropertyName("aircraft")]
        public Aircraft? Aircraft { get; set; }

        [JsonPropertyName("operating")]
        public Operating? Operating { get; set; }

        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("numberOfStops")]
        public int NumberOfStops { get; set; }

        [JsonPropertyName("blacklistedInEU")]
        public bool BlacklistedInEU { get; set; }
    }

    public class Departure
    {
        [JsonPropertyName("iataCode")]
        public string? IataCode { get; set; }

        [JsonPropertyName("at")]
        public DateTime At { get; set; }
    }

    public class Arrival
    {
        [JsonPropertyName("iataCode")]
        public string? IataCode { get; set; }

        [JsonPropertyName("at")]
        public DateTime At { get; set; }
    }

    public class Aircraft
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }

    public class Operating
    {
        [JsonPropertyName("carrierCode")]
        public string? CarrierCode { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("total")]
        public string? Total { get; set; }

        [JsonPropertyName("base")]
        public string? Base { get; set; }

        [JsonPropertyName("fees")]
        public List<Fee>? Fees { get; set; }

        [JsonPropertyName("grandTotal")]
        public string? GrandTotal { get; set; }
    }

    public class Fee
    {
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PricingOptions
    {
        [JsonPropertyName("fareType")]
        public List<string>? FareType { get; set; }

        [JsonPropertyName("includedCheckedBagsOnly")]
        public bool IncludedCheckedBagsOnly { get; set; }
    }

    public class TravelerPricing
    {
        [JsonPropertyName("travelerId")]
        public string? TravelerId { get; set; }

        [JsonPropertyName("fareOption")]
        public string? FareOption { get; set; }

        [JsonPropertyName("travelerType")]
        public string? TravelerType { get; set; }

        [JsonPropertyName("price")]
        public Price? Price { get; set; }

        [JsonPropertyName("fareDetailsBySegment")]
        public List<FareDetailsBySegment>? FareDetailsBySegment { get; set; }
    }

    public class FareDetailsBySegment
    {
        [JsonPropertyName("segmentId")]
        public string? SegmentId { get; set; }

        [JsonPropertyName("cabin")]
        public string? Cabin { get; set; }

        [JsonPropertyName("fareBasis")]
        public string? FareBasis { get; set; }

        [JsonPropertyName("class")]
        public string? Class { get; set; }

        [JsonPropertyName("includedCheckedBags")]
        public IncludedCheckedBags? IncludedCheckedBags { get; set; }
    }

    public class IncludedCheckedBags
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}





