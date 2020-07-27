using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class AllLeaguesResponse
    {
        [JsonProperty("SeasonData")]
        public List<Models.League.League> Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
