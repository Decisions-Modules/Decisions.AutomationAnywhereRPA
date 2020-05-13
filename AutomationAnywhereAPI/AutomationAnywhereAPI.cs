using AutomationAnywhereAPI.Endpoints;
using AutomationAnywhereAPI.Models;
using AutomationAnywhereAPI.Models.Requests;
using AutomationAnywhereAPI.Models.Responses;

namespace AutomationAnywhereAPI
{
    public static class AutomationAnywhereApi
    {
        private static readonly UsersService UsersService;
        private static readonly AutomationsService AutomationsService;
        private static readonly BotsService BotsService;

        static AutomationAnywhereApi()
        {
            UsersService = new UsersService();
            AutomationsService = new AutomationsService();
            BotsService = new BotsService();
        }

        public static ListUsersResponse UsersList(Connection connection, ListUsersRequest request)
        {
           return UsersService.List(connection, request);
        }

        public static User UsersEdit(Connection connection, int userId, User user)
        {
            return UsersService.Edit(connection, userId, user);
        }

        public static User UsersCreate(Connection connection, CreateUserRequest createUserRequest)
        {
            return UsersService.Create(connection, createUserRequest);
        }

        public static User UsersRemove(Connection connection, int userId)
        {
            return UsersService.Remove(connection, userId);
        }

        public static AutomationsListResponse AutomationsList(Connection connection, AutomationsListRequest request)
        {
            return AutomationsService.List(connection, request);
        }

        public static void AutomationsEdit(Connection connection, int automationId)
        {
            AutomationsService.Edit(connection, automationId);
        }

        public static object AutomationsRemove(Connection connection, AutomationsAddRemoveRequest request)
        {
            return AutomationsService.Remove(connection, request);
        }

        public static StartBotResponse StartBot(Connection connection, StartBotRequest request)
        {
            return BotsService.Start(connection, request);
        }

        public static void CancelBot(Connection connection, int botId)
        {
            BotsService.Cancel(connection, botId);
        }

        public static StatusBotResponse GetBotStatus(Connection connection, StatusBotRequest request)
        {
            return BotsService.GetStatus(connection, request);
        }

        public static void GetBotHistoryInformation(Connection connection, int botId)
        {
            BotsService.GetHistoryInformation(connection, botId);
        }
    }
}
