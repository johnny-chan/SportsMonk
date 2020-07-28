using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.Standings
{
    public class Overall
    {
        [JsonProperty("games_played")]
        public int GamesPlayed { get; set; }

        [JsonProperty("won")]
        public int Won { get; set; }

        [JsonProperty("draw")]
        public int Draw { get; set; }

        [JsonProperty("lost")]
        public int Lost { get; set; }

        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        [JsonProperty("goals_against")]
        public int GoalsAgainst { get; set; }
    }
}