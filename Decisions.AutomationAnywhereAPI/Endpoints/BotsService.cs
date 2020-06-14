using Decisions.AutomationAnywhereAPI.Extensions;
using Decisions.AutomationAnywhereAPI.Models;
using Decisions.AutomationAnywhereAPI.Models.Requests;
using Decisions.AutomationAnywhereAPI.Models.Responses;
using System;
using System.Net.Http;

namespace Decisions.AutomationAnywhereAPI.Endpoints
{
    public class BotsService : Endpoint
    {
        public StartBotResponse Start(Connection connection, StartBotRequest startBotRequest)
        {
            var request = Request(connection, $"http://{connection.Url}/v2/automations/deploy", HttpMethod.Post);
            request.AddJsonContent(startBotRequest);
            return Client.Execute<StartBotResponse>(request);
        }

        public void Cancel(Connection connection, int botId)
        {
            throw new Exception("Cancel Bot API is currently unavailable");
        }

        public StatusBotResponse GetStatus(Connection connection, StatusBotRequest statusBotRequest)
        {
            var request = Request(connection, $"http://{connection.Url}/v2/activity/list", HttpMethod.Post);
            request.AddJsonContent(statusBotRequest);
            return Client.Execute<StatusBotResponse>(request);
        }

        public void GetHistoryInformation(Connection connection, int botId)
        {
            throw new Exception("Activity History API is currently unavailable");
        }
    }
}
