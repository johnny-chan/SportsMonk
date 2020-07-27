using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class SeasonsData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("league_id")]
        public int LeagueId { get; set; }

        [JsonProperty("is_current_season")]
        public bool IsCurrentSeason { get; set; }

        [JsonProperty("current_round_id")]
        public object CurrentRoundId { get; set; }

        [JsonProperty("current_stage_id")]
        public int? CurrentStageId { get; set; }
    }
}