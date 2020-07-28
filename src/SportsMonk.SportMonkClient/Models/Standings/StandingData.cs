using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.Standings
{
    public class StandingData
    {

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("team_id")]
        public int TeamId { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("round_id")]
        public int RoundId { get; set; }

        [JsonProperty("round_name")]
        public int RoundName { get; set; }

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("group_name")]
        public object GroupName { get; set; }

        [JsonProperty("overall")]
        public Overall Overall { get; set; }

        [JsonProperty("home")]
        public Home Home { get; set; }

        [JsonProperty("away")]
        public Away Away { get; set; }

        [JsonProperty("total")]
        public Total Total { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("recent_form")]
        public string RecentForm { get; set; }

        [JsonProperty("status")]
        public object Status { get; set; }

    }
}