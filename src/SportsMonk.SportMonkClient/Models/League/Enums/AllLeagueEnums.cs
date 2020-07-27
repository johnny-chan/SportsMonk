using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League.Enums
{
    public enum AllLeagueEnums
    {
        [JsonProperty("Season")]
        Season,

        [JsonProperty("Seasons")]
        Seasons,

        [JsonProperty("Country")]
        Country
    }
}
