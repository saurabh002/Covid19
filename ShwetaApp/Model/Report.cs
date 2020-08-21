using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShwetaApp.Model
{
    public class Report
    {
        [JsonProperty(PropertyName = "active_cases")]
        public string   ActiveCases{ get; set; }

        [JsonProperty(PropertyName = "confirmed_cases")]
        public string ConfirmedCases { get; set; }

        [JsonProperty(PropertyName = "death_cases")]
        public string DeathCases { get; set; }

        [JsonProperty(PropertyName = "last_updated")]
        public string LastUpdated { get; set; }

        //        "active_cases": 692028,
        //"active_rate": 23.82,
        //"confirmed_cases": 2905823,
        //"death_cases": 54849,
        //"death_rate": 1.89,
        //"delta_change_active_cases": 5633,
        //"delta_change_death_cases": 983,
        //"delta_change_recovered_cases": 62282,
        //"last_total_active_cases": 686395,
        //"last_total_death_cases": 53866,
        //"last_total_recovered_cases": 2096664,
        //"last_updated": "21 August 2020, 08:00 IST (GMT+5:30)",
        //"migrated_cases": 1,
        //"passengers_screened": 1524266,
        //"recovered_cases": 2158946,
        //"recovered_rate": 74.3
    }
}
