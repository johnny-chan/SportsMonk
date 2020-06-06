using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class Subscription
    {
        [JsonProperty("started_at")]
        public StartedAt StartedAt { get; set; }

        [JsonProperty("trial_ends_at")]
        public object TrialEndsAt { get; set; }

        [JsonProperty("ends_at")]
        public object EndsAt { get; set; }
    }
}