using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class Seasons
    {
        [JsonProperty("SeasonData")]
        public List<SeasonsData> Data { get; set; }
    }
}