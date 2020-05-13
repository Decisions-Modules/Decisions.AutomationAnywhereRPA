using AutomationAnywhereAPI.Models.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationAnywhereAPI.Tests
{
    [TestClass]
    public class Automations : TestBase
    {
        [TestMethod, TestCategory("Automations.List")]
        public void List()
        {
            var request = new AutomationsListRequest();
            var automations = AutomationAnywhereApi.AutomationsList(Connection, request);
            Assert.IsTrue(automations != null);
        }

        [TestMethod, TestCategory("Automations.CreateEditRemove")]
        public void CreateEditRemove()
        {
            AutomationAnywhereApi.AutomationsEdit(Connection, 0);
            //Assert.IsTrue(editedAutomation != null);

            var request = new AutomationsAddRemoveRequest();
            var removedAutomation = AutomationAnywhereApi.AutomationsRemove(Connection, request);
            Assert.IsTrue(removedAutomation != null);
        }
    }
}
