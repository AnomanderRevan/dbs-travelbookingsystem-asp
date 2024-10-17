using System.Text.Json.Serialization;

namespace TravelBookingSystemMVC.Models.Api.Transport
{
    public class TransferOfferResponseModel
    {
        [JsonPropertyName("data")]
        public List<TransferOffer>? Data { get; set; }
    }

    public class TransferOffer
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("transferType")]
        public string? TransferType { get; set; }

        [JsonPropertyName("start")]
        public TransferLocation? Start { get; set; }

        [JsonPropertyName("end")]
        public TransferEnd? End { get; set; }

        [JsonPropertyName("stopOvers")]
        public List<StopOver>? StopOvers { get; set; }

        [JsonPropertyName("vehicle")]
        public Vehicle? Vehicle { get; set; }

        [JsonPropertyName("serviceProvider")]
        public ServiceProvider? ServiceProvider { get; set; }

        [JsonPropertyName("quotation")]
        public Quotation? Quotation { get; set; }

        [JsonPropertyName("converted")]
        public Quotation? Converted { get; set; }

        [JsonPropertyName("extraServices")]
        public List<ExtraService>? ExtraServices { get; set; }

        [JsonPropertyName("equipment")]
        public List<Equipment>? Equipment { get; set; }

        [JsonPropertyName("cancellationRules")]
        public List<CancellationRule>? CancellationRules { get; set; }

        [JsonPropertyName("methodsOfPaymentAccepted")]
        public List<string>? MethodsOfPaymentAccepted { get; set; }

        [JsonPropertyName("discountCodes")]
        public List<DiscountCode>? DiscountCodes { get; set; }

        [JsonPropertyName("distance")]
        public Distance? Distance { get; set; }

        [JsonPropertyName("startConnectedSegment")]
        public ConnectedSegment? StartConnectedSegment { get; set; }

        [JsonPropertyName("passengerCharacteristics")]
        public List<PassengerCharacteristic>? PassengerCharacteristics { get; set; }
    }

    public class TransferLocation
    {
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonPropertyName("locationCode")]
        public string? LocationCode { get; set; }
    }

    public class TransferEnd
    {
        [JsonPropertyName("address")]
        public Address? Address { get; set; }

        [JsonPropertyName("googlePlaceId")]
        public string? GooglePlaceId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("line")]
        public string? Line { get; set; }

        [JsonPropertyName("zip")]
        public string? Zip { get; set; }

        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("cityName")]
        public string? CityName { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }

    public class StopOver
    {
        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonPropertyName("location")]
        public StopOverLocation? Location { get; set; }
    }

    public class StopOverLocation
    {
        [JsonPropertyName("locationCode")]
        public string? LocationCode { get; set; }

        [JsonPropertyName("address")]
        public Address? Address { get; set; }

        [JsonPropertyName("googlePlaceId")]
        public string? GooglePlaceId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class Vehicle
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("seats")]
        public List<Seat>? Seats { get; set; }

        [JsonPropertyName("baggages")]
        public List<Baggage>? Baggages { get; set; }

        [JsonPropertyName("imageURL")]
        public string? ImageURL { get; set; }
    }

    public class Seat
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class Baggage
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }

    public class ServiceProvider
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("logoUrl")]
        public string? LogoUrl { get; set; }

        [JsonPropertyName("termsUrl")]
        public string? TermsUrl { get; set; }

        [JsonPropertyName("contacts")]
        public Contacts? Contacts { get; set; }

        [JsonPropertyName("settings")]
        public List<string>? Settings { get; set; }
    }

    public class Contacts
    {
        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }
    }

    public class Quotation
    {
        [JsonPropertyName("monetaryAmount")]
        public string? MonetaryAmount { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("isEstimated")]
        public bool IsEstimated { get; set; }

        [JsonPropertyName("base")]
        public BaseQuotation? Base { get; set; }

        [JsonPropertyName("discount")]
        public Discount? Discount { get; set; }

        [JsonPropertyName("fees")]
        public List<Fee>? Fees { get; set; }

        [JsonPropertyName("totalTaxes")]
        public TotalTaxes? TotalTaxes { get; set; }

        [JsonPropertyName("totalFees")]
        public TotalFees? TotalFees { get; set; }
    }

    public class BaseQuotation
    {
        [JsonPropertyName("monetaryAmount")]
        public string? MonetaryAmount { get; set; }
    }

    public class Discount
    {
        [JsonPropertyName("monetaryAmount")]
        public string? MonetaryAmount { get; set; }
    }

    public class Fee
    {
        [JsonPropertyName("indicator")]
        public string? Indicator { get; set; }

        [JsonPropertyName("monetaryAmount")]
        public string? MonetaryAmount { get; set; }
    }

    public class TotalTaxes
    {
        [JsonPropertyName("monetaryAmount")]
        public string? MonetaryAmount { get; set; }
    }

    public class TotalFees
    {
        [JsonPropertyName("monetaryAmount")]
        public string? MonetaryAmount { get; set; }
    }

    public class ExtraService
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("quotation")]
        public Quotation? Quotation { get; set; }

        [JsonPropertyName("converted")]
        public Quotation? Converted { get; set; }

        [JsonPropertyName("isBookable")]
        public bool IsBookable { get; set; }

        [JsonPropertyName("taxIncluded")]
        public bool TaxIncluded { get; set; }

        [JsonPropertyName("includedInTotal")]
        public bool IncludedInTotal { get; set; }
    }

    public class Equipment
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("quotation")]
        public Quotation? Quotation { get; set; }

        [JsonPropertyName("converted")]
        public Quotation? Converted { get; set; }

        [JsonPropertyName("isBookable")]
        public bool IsBookable { get; set; }

        [JsonPropertyName("taxIncluded")]
        public bool TaxIncluded { get; set; }

        [JsonPropertyName("includedInTotal")]
        public bool IncludedInTotal { get; set; }
    }

    public class CancellationRule
    {
        [JsonPropertyName("feeType")]
        public string? FeeType { get; set; }

        [JsonPropertyName("feeValue")]
        public string? FeeValue { get; set; }

        [JsonPropertyName("metricType")]
        public string? MetricType { get; set; }

        [JsonPropertyName("metricMin")]
        public string? MetricMin { get; set; }

        [JsonPropertyName("metricMax")]
        public string? MetricMax { get; set; }
    }

    public class DiscountCode
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    public class Distance
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
    }

    public class ConnectedSegment
    {
        [JsonPropertyName("transportationType")]
        public string? TransportationType { get; set; }

        [JsonPropertyName("transportationNumber")]
        public string? TransportationNumber { get; set; }

        [JsonPropertyName("departure")]
        public SegmentLocation? Departure { get; set; }

        [JsonPropertyName("arrival")]
        public SegmentLocation? Arrival { get; set; }
    }

    public class SegmentLocation
    {
        [JsonPropertyName("localDateTime")]
        public DateTime LocalDateTime { get; set; }

        [JsonPropertyName("iataCode")]
        public string? IataCode { get; set; }
    }

    public class PassengerCharacteristic
    {
        [JsonPropertyName("passengerTypeCode")]
        public string? PassengerTypeCode { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}