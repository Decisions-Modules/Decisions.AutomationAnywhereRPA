using Newtonsoft.Json;
using System.Net.Http;

namespace AutomationAnywhereAPI.Extensions
{
    internal static class HttpClientExtensions
    {
        public static T Execute<T>(this HttpClient client, HttpRequestMessage request)
        {
            var response = client.SendAsync(request).Result;

            if (response.IsSuccessStatusCode == false && response.Content.Headers.ContentType.MediaType != "application/json")
            {
                response.EnsureSuccessStatusCode();
            }

            string resultData = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<T>(resultData);

            return result;
        }
    }
}
