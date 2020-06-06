using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class AllLeaguesResponse
    {
        [JsonProperty("data")]
        public List<League> Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
