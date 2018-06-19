using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Linq;

namespace YnabClient.Tests
{
    [TestClass]
    public class YnabClientTests
    {
        [TestMethod]
        public void CanGetBudgets()
        {
            var token = ConfigurationManager.AppSettings["AccessToken"];
            var client = new YnabClient(token);
            var response = client.GetBudgets();

            Assert.IsTrue(response.Data.Budgets.Count() > 0);

            Console.WriteLine($"count: {response.Data.Budgets.Count()}");

            var list = response.Data.Budgets.ToList();
            for (var b = 0; b < list.Count; b++)
                Console.WriteLine($"[{b}] name: {list[b].Name}");
        }
    }
}
