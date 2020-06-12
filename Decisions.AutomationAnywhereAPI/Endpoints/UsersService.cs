using Decisions.AutomationAnywhereAPI.Extensions;
using Decisions.AutomationAnywhereAPI.Models;
using Decisions.AutomationAnywhereAPI.Models.Requests;
using Decisions.AutomationAnywhereAPI.Models.Responses;
using System.Net.Http;
using System.Threading.Tasks;

namespace Decisions.AutomationAnywhereAPI.Endpoints
{
    public class UsersService : Endpoint
    {
        public ListUsersResponse List(Connection connection, ListUsersRequest listUsersRequest)
        {
            var request = Request(connection, $"http://{connection.Url}/v1/usermanagement/users/list", HttpMethod.Post);
            request.AddJsonContent(listUsersRequest);
            return Client.Execute<ListUsersResponse>(request);
        }

        public User Edit(Connection connection, int userId, User user)
        {
            var request = Request(connection, $"http://{connection.Url}/v1/usermanagement/users/{userId}", HttpMethod.Put);
            request.AddJsonContent(user);
            return Client.Execute<User>(request);
        }

        public User Create(Connection connection, CreateUserRequest createUserRequest)
        {
            var request = Request(connection, $"http://{connection.Url}/v1/usermanagement/users", HttpMethod.Post);
            request.AddJsonContent(createUserRequest);
            return Client.Execute<User>(request);
        }

        public User Remove(Connection connection, int userId)
        {
            var request = Request(connection, $"http://{connection.Url}/v1/usermanagement/users/{userId}", HttpMethod.Delete);
            return Client.Execute<User>(request);
        }
    }
}
