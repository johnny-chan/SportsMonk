using System;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class League
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("legacy_id")]
        public int? LegacyId { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_cup")]
        public bool IsCup { get; set; }

        [JsonProperty("current_season_id")]
        public int? CurrentSeasonId { get; set; }

        [JsonProperty("current_round_id")]
        public int? CurrentRoundId { get; set; }

        [JsonProperty("current_stage_id")]
        public int? CurrentStageId { get; set; }

        [JsonProperty("live_standings")]
        public bool LiveStandings { get; set; }

        [JsonProperty("coverage")]
        public Coverage Coverage { get; set; }

        [JsonProperty("seasons")]
        public Seasons Seasons { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }
    }
}