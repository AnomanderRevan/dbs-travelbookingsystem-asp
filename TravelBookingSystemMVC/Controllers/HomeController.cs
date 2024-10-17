using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TravelBookingSystemMVC.Models;
using System.Text.Json;

namespace TravelBookingSystemMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index([FromServices] FlightApiService api)
    {
        //await api.ConnectOAuth();
        var results = await api.GetFlightOffers("DUB", "NYC", "2024-11-01", 1, 0, 0, "ECONOMY", null);
        Console.WriteLine(JsonSerializer.Serialize(results.Data));
        ViewBag.Results = results.Data;
        return View();
    }

    public IActionResult Flights()
    {
        return View();
    }

    public IActionResult Hotels()
    {
        return View();
    }

    public IActionResult CarRental()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
