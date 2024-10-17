using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TravelBookingSystemMVC.Models.ApiResponse;
using TravelBookingSystemMVC.Services.Api;

public class FlightApiService : AmadeusApiService
{
    public FlightApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory, configuration)
    {

    }


    public async Task<BusiestPeriodResponseModel> GetBusiestTravelPeriodsOfYear(string cityCode, int year)
    {
        var message = new HttpRequestMessage(HttpMethod.Get,
            $"/v1/travel/analytics/air-traffic/busiest-period?cityCode={cityCode}&period={year}");

        var response = await HttpClient.SendAsync(message);
        using var stream = await response.Content.ReadAsStreamAsync();
        var result = await JsonSerializer.DeserializeAsync<BusiestPeriodResponseModel>(stream);

        if (result == null)
        {
            throw new InvalidOperationException("Failed to deserialize the response.");
        }

        return result;
    }

    public async Task<FlightOffersResponseModel> GetFlightOffers(string originLocationCode, string destinationLocationCode, string departureDate, int adults, int children, int infants, string travelClass, int? maxPrice)
    {
        var message = new HttpRequestMessage(HttpMethod.Get,
            $"/v2/shopping/flight-offers?max=9&originLocationCode={originLocationCode}&destinationLocationCode={destinationLocationCode}&departureDate={departureDate}&adults={adults}&children={children}&infants={infants}&travelClass={travelClass}&nonStop=true");

        var response = await HttpClient.SendAsync(message);
        using var stream = await response.Content.ReadAsStreamAsync();
        var result = await JsonSerializer.DeserializeAsync<FlightOffersResponseModel>(stream);

        if (result == null)
        {
            throw new InvalidOperationException("Failed to deserialize the response.");
        }

        return result;
    }


    public async Task<AirlineCodeLookupResponseModel> GetAirlinesByCodes(List<string> airlineCodes)
    {
        var message = new HttpRequestMessage(HttpMethod.Get,
            $"/v1/reference-data/airlines?airlineCodes={string.Join(",", airlineCodes)}");

        var response = await HttpClient.SendAsync(message);
        using var stream = await response.Content.ReadAsStreamAsync();
        var result = await JsonSerializer.DeserializeAsync<AirlineCodeLookupResponseModel>(stream);

        if (result == null)
        {
            throw new InvalidOperationException("Failed to deserialize the response.");
        }

        return result;
    }
}