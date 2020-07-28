using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.Standings
{
    public class Standings
    {

        [JsonProperty("data")]
        public List<StandingData> Data { get; set; }

    }
}