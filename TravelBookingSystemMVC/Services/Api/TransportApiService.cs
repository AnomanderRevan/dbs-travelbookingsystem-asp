using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TravelBookingSystemMVC.Models.Api.Transport;
using TravelBookingSystemMVC.Services.Api;

public class TransportApiService : AmadeusApiService
{
    public TransportApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory, configuration)
    {

    }
}