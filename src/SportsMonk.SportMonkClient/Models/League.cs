using System;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class League
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("legacy_id")]
        public long? LegacyId { get; set; }

        [JsonProperty("country_id")]
        public long CountryId { get; set; }

        [JsonProperty("logo_path")]
        public Uri LogoPath { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_cup")]
        public bool IsCup { get; set; }

        [JsonProperty("current_season_id")]
        public long? CurrentSeasonId { get; set; }

        [JsonProperty("current_round_id")]
        public long? CurrentRoundId { get; set; }

        [JsonProperty("current_stage_id")]
        public long? CurrentStageId { get; set; }

        [JsonProperty("live_standings")]
        public bool LiveStandings { get; set; }

        [JsonProperty("coverage")]
        public Coverage Coverage { get; set; }
    }
}