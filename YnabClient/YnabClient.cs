using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace YnabClient
{
    public class YnabClient
    {
        private readonly RestClient _client;

        public YnabClient(string accessToken)
        {
            _client = new RestClient("https://api.youneedabudget.com/v1");
            _client.AddDefaultHeader("Authorization", $"Bearer {accessToken}");
        }

        public YnabResponse<BudgetsData> GetBudgets()
        {
            var request = new RestRequest("budgets");
            var response = _client.Execute<YnabResponse<BudgetsData>>(request);
            return response.Data;
        }

        public YnabResponse<UserData> GetUser()
        {
            var request = new RestRequest("user");
            var response = _client.Execute<YnabResponse<UserData>>(request);
            Console.WriteLine(FormatJson(response.Content));
            return response.Data;
        }

        public static string FormatJson(string json)
        {
            return JToken.Parse(json).ToString(Formatting.Indented);
        }
    }
}
