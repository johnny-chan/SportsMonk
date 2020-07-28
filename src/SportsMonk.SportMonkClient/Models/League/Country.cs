using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class Country
    {
        [JsonProperty("SeasonData")]
        public CountryData Data { get; set; }
    }
}