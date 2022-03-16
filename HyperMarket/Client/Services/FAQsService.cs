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

        public async Task<Faq> GetFaqs(int id)
        {
            var user = await _httpClient.GetFromJsonAsync<Faq>($"/api/faqs/{id}");
            return user;
        }

    }
}
