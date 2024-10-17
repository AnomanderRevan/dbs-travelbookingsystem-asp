using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TravelBookingSystemMVC.Models.ApiResponse;

namespace TravelBookingSystemMVC.Services.Api;

public abstract class AmadeusApiService
{
    protected readonly HttpClient HttpClient;
    protected readonly IConfiguration Configuration;
    protected readonly string? ApiKey;
    protected readonly string? ApiSecret;
    protected string? BearerToken;

    protected AmadeusApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        HttpClient = httpClientFactory.CreateClient("Amadeus");
        Configuration = configuration;
        ApiKey = Configuration["AmadeusApi:ApiKey"];
        ApiSecret = Configuration["AmadeusApi:ApiSecret"];

        if (ApiKey == null || ApiSecret == null)
        {
            throw new InvalidOperationException("Failed to retrieve API credentials from config.");
        }

        ConnectOAuth().Wait();
    }

    protected async Task ConnectOAuth()
    {
        var message = new HttpRequestMessage(HttpMethod.Post, "/v1/security/oauth2/token");
        message.Content = new StringContent(
            $"grant_type=client_credentials&client_id={ApiKey}&client_secret={ApiSecret}",
            Encoding.UTF8, "application/x-www-form-urlencoded"
        );

        var results = await HttpClient.SendAsync(message);
        var responseContent = await results.Content.ReadAsStringAsync();

        // Print the response content to the console
        Console.WriteLine(responseContent);

        await using var stream = await results.Content.ReadAsStreamAsync();
        var oauthResults = await JsonSerializer.DeserializeAsync<OAuthResponseModel>(stream);

        if (oauthResults == null || oauthResults.AccessToken == null)
        {
            throw new InvalidOperationException("Failed to deserialize the OAuth response or access token is null.");
        }

        BearerToken = oauthResults.AccessToken;
        ConfigBearerTokenHeader();
    }

    protected void ConfigBearerTokenHeader()
    {
        if (HttpClient.DefaultRequestHeaders.Contains("Authorization"))
        {
            HttpClient.DefaultRequestHeaders.Remove("Authorization");
        }
        HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {BearerToken}");
    }


}