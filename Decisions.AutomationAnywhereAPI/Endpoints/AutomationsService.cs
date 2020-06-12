using Decisions.AutomationAnywhereAPI.Extensions;
using Decisions.AutomationAnywhereAPI.Models;
using Decisions.AutomationAnywhereAPI.Models.Requests;
using Decisions.AutomationAnywhereAPI.Models.Responses;
using System;
using System.Net.Http;

namespace Decisions.AutomationAnywhereAPI.Endpoints
{
    public class AutomationsService : Endpoint
    {
        public AutomationsListResponse List(Connection connection, AutomationsListRequest automationsListRequest)
        {
            var request = Request(connection, $"http://{connection.Url}/v2/repository/file/list", HttpMethod.Post);
            request.AddJsonContent(automationsListRequest);
            return Client.Execute<AutomationsListResponse>(request);
        }

        public void Edit(Connection connection, int automationId)
        {
            throw new Exception("Edit Automations API is currently unavailable");
        }

        public object Remove(Connection connection, AutomationsAddRemoveRequest automationsAddRemoveRequest)
        {
            var request = Request(connection, $"http://{connection.Url}/v1/files/manualdependencies/remove", HttpMethod.Delete);
            request.AddJsonContent(automationsAddRemoveRequest);
            return Client.Execute<object>(request);
        }

        public object Create(Connection connection, AutomationsAddRemoveRequest automationsAddRemoveRequest)
        {
            var request = Request(connection, $"https://{connection.Url}/v1/files/manualdependencies/add", HttpMethod.Post);
            request.AddJsonContent(automationsAddRemoveRequest);
            return Client.Execute<object>(request);
        }
    }
}
