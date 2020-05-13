using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace AutomationAnywhereAPI.Extensions
{
    internal static class HttpRequestMessageExtensions
    {
        public static void AddJsonContent(this HttpRequestMessage request, object content)
        {
            var json = JsonConvert.SerializeObject(content);
            using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                request.Content = stringContent;
            }
        }
    }
}
