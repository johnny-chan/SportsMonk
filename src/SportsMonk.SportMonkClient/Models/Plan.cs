using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class Plan
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("request_limit")]
        public string RequestLimit { get; set; }
    }
}