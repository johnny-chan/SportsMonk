using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.Standings
{
    public class StandingResponse
    {
        [JsonProperty("data")]
        public List<StandingResult> Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}