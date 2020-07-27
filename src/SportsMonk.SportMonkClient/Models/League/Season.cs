using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class Season
    {
        [JsonProperty("SeasonData")]
        public SeasonData Data { get; set; }
    }
}