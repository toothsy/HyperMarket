using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperMarket.DB.Models;
using System.Net.Http.Json;


namespace HyperMarket.Data.Interfaces
{
    public class FAQsService : IFAQsService
    {
        private readonly HttpClient _httpClient;

        public FAQsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Faq>> GetAllFaqs()
        {
            var user = await _httpClient.GetFromJsonAsync<List<Faq>>($"/api/faqs/GetAllFaqs");
            return user;
        }

    }
}
