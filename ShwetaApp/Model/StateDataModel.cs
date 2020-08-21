using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShwetaApp.Model
{
    public class StateDataModel
    {
        [JsonProperty(PropertyName = "active")]
        public string Active { get; set; }

        [JsonProperty(PropertyName = "confirmed")]
        public string Confirmed { get; set; }

        [JsonProperty(PropertyName = "recovered")]
        public string Recovered { get; set; }

        [JsonProperty(PropertyName = "deaths")]
        public string Deaths { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}
