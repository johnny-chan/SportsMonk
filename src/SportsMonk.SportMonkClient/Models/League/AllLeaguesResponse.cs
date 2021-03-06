﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class AllLeaguesResponse
    {
        [JsonProperty("data")]
        public List<LeagueResult> Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}