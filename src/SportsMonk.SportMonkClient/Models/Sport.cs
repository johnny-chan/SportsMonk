using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class Sport
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }
    }
}