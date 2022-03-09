using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HyperMarket.DB.Models;


using HyperMarket.Data;
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
            var locat = await _httpClient.GetFromJsonAsync<Location>($"/api/location/{id}");
            return locat;
        }
    }
}
