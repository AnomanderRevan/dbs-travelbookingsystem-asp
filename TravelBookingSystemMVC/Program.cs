using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TravelBookingSystemMVC.Data;
using TravelBookingSystemMVC.Services;
using TravelBookingSystemMVC.Services.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

//KW: Register the Swagger generator, defining 1 or more Swagger documents
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//KW: Read the base URL for the Amadeus API from the configuration
var amadeusBaseUrl = builder.Configuration["AmadeusApi:BaseUrl"] ?? "https://test.api.amadeus.com";

//KW: Add named httpclients for 3rd party APIs
builder.Services.AddHttpClient("Amadeus", HttpClient =>
{
    HttpClient.BaseAddress = new Uri(amadeusBaseUrl);
});

//KW: Register the services
builder.Services.AddScoped<FlightApiService>();
builder.Services.AddScoped<HotelApiService>();
builder.Services.AddScoped<TransportApiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

//KW: Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
