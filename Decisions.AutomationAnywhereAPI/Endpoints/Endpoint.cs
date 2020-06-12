using Decisions.AutomationAnywhereAPI.Models;
using Decisions.AutomationAnywhereAPI.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Decisions.AutomationAnywhereAPI.Endpoints
{
    public abstract class Endpoint
    {
        protected HttpClient Client { get; private set; }

        internal Endpoint()
        {
            var handler = new HttpClientHandler();

            Client = new HttpClient(handler);
        }

        protected HttpRequestMessage Request(Connection connection, string url, HttpMethod method)
        {
            var request = new HttpRequestMessage(method, new Uri(url));

            var token = GetToken(connection.Credentials, connection.Url).Token;

            AddAuth(request, token);

            return request;
        }

        private AuthResponse GetToken(Credentials credentials, string controlRoomUrl)
        {
            using(var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, $"http://{controlRoomUrl}/v1/authentication"))
                {
                    var json = JsonConvert.SerializeObject(credentials);
                    using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                    {
                        request.Content = stringContent;

                        using (var response = client.SendAsync(request).Result)
                        {
                            if (!response.IsSuccessStatusCode)
                                return null;

                            string resultData = response.Content.ReadAsStringAsync().Result;
                            var result = JsonConvert.DeserializeObject<AuthResponse>(resultData);

                            return result;
                        }
                    }
                }
            }
        }

        protected HttpRequestMessage Request(Connection connection, string fragment)
        {
            return Request(connection, fragment, HttpMethod.Get);
        }

        protected virtual HttpRequestMessage AddAuth(HttpRequestMessage request, string token)
        {
            request.Headers.Add("X-Authorization", token);

            return request;
        }
    }
}
