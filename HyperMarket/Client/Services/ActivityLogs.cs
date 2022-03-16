//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using HyperMarket.DB.Models;
//using System.Net.Http.Json;

//namespace HyperMarket.Data.Interfaces
//{
//    public class ActivityLogs : IActivityLogs
//    {
//            private readonly HttpClient _httpClient;

//            public ActivityLogs(HttpClient httpClient)
//            {
//                _httpClient = httpClient;
//            }
//        public async Task<List<ActivityLog>> GetActivityLogs()
//        {
//            return await _httpClient.GetFromJsonAsync<List<ActivityLog>>($"api/activitylog");
//        }
//        public async void SaveActLog(ActivityLogModel actlog)
//        {
//            var test = new HttpResponseMessage();
//            try
//            {
//                test = await _httpClient.PostAsJsonAsync($"/api/activitylog", actlog);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.StackTrace);
//            }
//            finally
//            {
//                Console.WriteLine(test);
//            }
//        }
//    }
