using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.Standings
{
    public class StandingResult
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("league_id")]
        public int LeagueId { get; set; }

        [JsonProperty("season_id")]
        public int SeasonId { get; set; }

        [JsonProperty("round_id")]
        public int RoundId { get; set; }

        [JsonProperty("round_name")]
        public int RoundName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stage_id")]
        public int StageId { get; set; }

        [JsonProperty("stage_name")]
        public string StageName { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("standings")]
        public Standings Standings { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

    }


}
