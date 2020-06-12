using Decisions.AutomationAnywhereAPI.Models.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decisions.AutomationAnywhereAPI.Tests
{
    [TestClass]
    public class Users : TestBase
    {
        [TestMethod, TestCategory("Users.List")]
        public void List()
        {
            var request = new ListUsersRequest();
            var users = AutomationAnywhereApi.UsersList(Connection, request);
            Assert.IsTrue(users != null);
        }

        [TestMethod, TestCategory("Users.CreateEditRemove")]
        public void CreateEditRemove()
        {
            var request = new CreateUserRequest();
            var createdUser = AutomationAnywhereApi.UsersCreate(Connection, request);
            Assert.IsTrue(createdUser != null);

            var editedUser = AutomationAnywhereApi.UsersEdit(Connection, createdUser.Id, createdUser);
            Assert.IsTrue(editedUser != null);

            var removedUser = AutomationAnywhereApi.UsersRemove(Connection, editedUser.Id);
            Assert.IsTrue(removedUser != null);
        }
    }
}
