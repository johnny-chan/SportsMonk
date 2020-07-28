using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public partial class Coverage
    {
        [JsonProperty("predictions")]
        public bool Predictions { get; set; }

        [JsonProperty("topscorer_goals")]
        public bool TopscorerGoals { get; set; }

        [JsonProperty("topscorer_assists")]
        public bool TopscorerAssists { get; set; }

        [JsonProperty("topscorer_cards")]
        public bool TopscorerCards { get; set; }
    }
}