using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace YnabClient
{
    public class BudgetCollection
    {
        [JsonProperty("budgets")]
        public IEnumerable<Budget> Budgets { get; set; }
    }
}
