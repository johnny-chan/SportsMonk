using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class Meta
    {
        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        [JsonProperty("sports")]
        public List<Sport> Sports { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}