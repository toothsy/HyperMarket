using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperMarket.DB.Models;
using System.Net.Http.Json;

namespace HyperMarket.Data.Interfaces
{
    public class ConfigService : IConfigService
    {
        private readonly HttpClient _httpClient;

        public ConfigService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Config>> GetGonfig()
        {
            return await _httpClient.GetFromJsonAsync<List<Config>>($"api/config");
        }
        public async Task<Config> GetConfigById(int id)
        {
            var config1 = await _httpClient.GetFromJsonAsync<Config>($"/api/config/{id}");
            return config1;
        }

    }
}
