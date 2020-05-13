using AutomationAnywhereAPI.Models.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationAnywhereAPI.Tests
{
    [TestClass]
    public class Bots : TestBase
    {
        [TestMethod, TestCategory("Bots.Start")]
        public void Start()
        {
            var request = new StartBotRequest();
            var bot = AutomationAnywhereApi.StartBot(Connection, request);
            Assert.IsTrue(bot != null);
        }

        [TestMethod, TestCategory("Bots.Cancel")]
        public void Cancel()
        {
            AutomationAnywhereApi.CancelBot(Connection, 0);
            //Assert.IsTrue(bot != null);
        }

        [TestMethod, TestCategory("Bots.GetStatus")]
        public void GetStatus()
        {
            var request = new StatusBotRequest();
            var bot = AutomationAnywhereApi.GetBotStatus(Connection, request);
            Assert.IsTrue(bot != null);
        }

        [TestMethod, TestCategory("Bots.GetHistoryInformation")]
        public void GetHistoryInformation()
        {
            AutomationAnywhereApi.GetBotHistoryInformation(Connection, 0);
            //Assert.IsTrue(bot != null);
        }
    }
}
