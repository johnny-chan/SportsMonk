using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.Standings
{
    public class Total
    {

        [JsonProperty("goal_difference")]
        public string GoalDifference { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

    }
}