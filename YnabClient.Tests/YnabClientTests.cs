using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Linq;

namespace YnabClient.Tests
{
    [TestClass]
    public class YnabClientTests
    {
        private string AccessToken => ConfigurationManager.AppSettings["AccessToken"];

        [TestMethod]
        public void CanGetBudgets()
        {
            var client = new YnabClient(AccessToken);
            YnabResponse<BudgetsData> response = client.GetBudgets();

            Assert.IsTrue(response.Data.Budgets.Count() > 0);

            Console.WriteLine($"count: {response.Data.Budgets.Count()}");

            var list = response.Data.Budgets.ToList();
            for (var b = 0; b < list.Count; b++)
                Console.WriteLine($"[{b}] name: {list[b].Name}");
        }

        [TestMethod]
        public void CanGetUser()
        {
            var client = new YnabClient(AccessToken);
            YnabResponse<UserData> response = client.GetUser();

            Assert.IsTrue(response.Data.User.Id.Length > 0);

            Console.WriteLine($"id: {response.Data.User.Id}");
        }
    }
}
