using System;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class StartedAt
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("timezone_type")]
        public long TimezoneType { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}