using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    public class LocationService : ILocationService
    {
        private readonly HttpClient _httpClient;

        public LocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<Location> GetLocationById(int id)
        {
            var location = await _httpClient.GetFromJsonAsync<Location>($"/api/location/GetLocationById/{id}");
            return location;
        }

        public async Task<Location> GetIdByLocation(string location)
        {
            var loc = await _httpClient.GetFromJsonAsync<Location>($"/api/location/{location}");
            return loc;
        }
        public async Task<List<Location>> GetAllLocation()
        {
            var location = await _httpClient.GetFromJsonAsync<List<Location>>($"/api/location/all");
            return location;
        }
    }
}
