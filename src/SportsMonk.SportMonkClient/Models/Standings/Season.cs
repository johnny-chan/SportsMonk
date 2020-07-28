using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.Standings
{
    public class Season
    {
        [JsonProperty("data")]
        public SeasonData SeasonData { get; set; }
    }
}